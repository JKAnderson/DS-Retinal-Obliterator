using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DS_Retinal_Obliterator
{
    public partial class MainForm : Form
    {
        private DSProcess dsProcess = null;
        private bool loaded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "DS Retinal Obliterator " + Application.ProductVersion;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dsProcess != null)
            {
                dsProcess.OverrideFilter(false);
                dsProcess.Close();
            }
        }

        private void timerCheckProcess_Tick(object sender, EventArgs e)
        {
            if (dsProcess == null)
            {
                foreach (Process candidate in Process.GetProcesses())
                {
                    if (candidate.MainWindowTitle == "DARK SOULS")
                    {
                        DSProcess result = DSProcess.Attach(candidate, out string version, out bool valid);
                        labelProcess.Text = candidate.Id.ToString();
                        labelVersion.Text = version;
                        if (valid)
                            labelVersion.ForeColor = Color.DarkGreen;
                        else
                            labelVersion.ForeColor = Color.DarkRed;
                        if (result != null)
                            dsProcess = result;
                    }
                }
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (dsProcess != null)
            {
                if (dsProcess.Alive())
                {
                    if (dsProcess.Loaded())
                    {
                        if (!loaded)
                        {
                            labelLoaded.Text = "Yes";
                            dsProcess.LoadPointers();
                            dsProcess.OverrideFilter(checkBoxActivate.Checked);
                            loaded = true;
                        }
                        else if (checkBoxActivate.Checked)
                            updateFilter();
                    }
                    else if (loaded)
                    {
                        labelLoaded.Text = "No";
                        loaded = false;
                    }
                }
                else
                {
                    dsProcess.Close();
                    dsProcess = null;
                    labelProcess.Text = "None";
                    labelVersion.Text = "None";
                    labelVersion.ForeColor = Color.Black;
                    labelLoaded.Text = "No";
                    loaded = false;
                }
            }
        }

        private void checkBoxActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (dsProcess != null)
                dsProcess.OverrideFilter(checkBoxActivate.Checked);
        }


        // I recommend not reading beyond this point if you don't like gross things
        private Random rand = new Random();
        private long startMS = 0, endMS = 0;
        private double satStart = 1, satEnd = 1;
        private double briStart = 1, briEnd = 1;
        private double conStart = 1, conEnd = 1;
        private double hueStart = 0, hueEnd = 0;

        private void updateFilter()
        {
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (now >= endMS)
            {
                satStart = satEnd;
                double satMin = (double)numericUpDownSatMin.Value;
                double satMax = (double)numericUpDownSatMax.Value;
                satEnd = satMin + rand.NextDouble() * (satMax - satMin);

                briStart = briEnd;
                double briMin = (double)numericUpDownBriMin.Value;
                double briMax = (double)numericUpDownBriMax.Value;
                briEnd = briMin + rand.NextDouble() * (briMax - briMin);

                conStart = conEnd;
                double conMin = (double)numericUpDownConMin.Value;
                double conMax = (double)numericUpDownConMax.Value;
                conEnd = conMin + rand.NextDouble() * (conMax - conMin);

                hueStart = hueEnd;
                double hueMin = (double)numericUpDownHueMin.Value;
                double hueMax = (double)numericUpDownHueMax.Value;
                hueEnd = hueMin + rand.NextDouble() * (hueMax - hueMin);

                startMS = now;
                endMS = now + (int)numericUpDownInterval.Value;
            }
            else
            {
                double progress = (now - startMS) / (double)numericUpDownInterval.Value;

                float brightness = (float)slerp(briStart, briEnd, progress);
                dsProcess.SetBrightness(brightness, brightness, brightness);
                textBoxBri.Text = brightness.ToString("N3");

                float contrast = (float)slerp(conStart, conEnd, progress);
                dsProcess.SetContrast(contrast, contrast, contrast);
                textBoxCon.Text = contrast.ToString("N3");

                float saturation = (float)slerp(satStart, satEnd, progress);
                dsProcess.SetSaturation(saturation);
                textBoxSat.Text = saturation.ToString("N3");

                float hue = (float)slerp(hueStart, hueEnd, progress);
                dsProcess.SetHue(hue);
                textBoxHue.Text = hue.ToString("N3");
            }
        }

        private static double slerp(double start, double end, double progress)
        {
            progress = progress * progress * (3 - 2 * progress);
            return start + (end - start) * progress;
        }
    }
}
