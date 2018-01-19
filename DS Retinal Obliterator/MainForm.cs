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
                            if (checkBoxActivate.Checked)
                                initFilter();
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
            {
                if (checkBoxActivate.Checked)
                    initFilter();
                else
                    dsProcess.OverrideFilter(false);
            }
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            resetFilter();
        }


        // I recommend not reading beyond this point if you don't like gross things
        private Random rand = new Random();
        private long startMS = 0, endMS = 0;
        private double briStart = 1, briEnd = 1, briNow = 1;
        private double conStart = 1, conEnd = 1, conNow = 1;
        private double satStart = 1, satEnd = 1, satNow = 1;
        private double hueStart = 0, hueEnd = 0, hueNow = 0;

        private void initFilter()
        {
            briNow = 1;
            conNow = 1;
            satNow = 1;
            hueNow = 0;
            resetFilter();
            updateFilter();
            dsProcess.OverrideFilter(true);
        }

        private void resetFilter()
        {
            briStart = briNow;
            double briMin = (double)numericUpDownBriMin.Value;
            double briMax = (double)numericUpDownBriMax.Value;
            briEnd = briMin + rand.NextDouble() * (briMax - briMin);

            conStart = conNow;
            double conMin = (double)numericUpDownConMin.Value;
            double conMax = (double)numericUpDownConMax.Value;
            conEnd = conMin + rand.NextDouble() * (conMax - conMin);

            satStart = satNow;
            double satMin = (double)numericUpDownSatMin.Value;
            double satMax = (double)numericUpDownSatMax.Value;
            satEnd = satMin + rand.NextDouble() * (satMax - satMin);

            hueStart = hueNow;
            double hueMin = (double)numericUpDownHueMin.Value;
            double hueMax = (double)numericUpDownHueMax.Value;
            hueEnd = hueMin + rand.NextDouble() * (hueMax - hueMin);

            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            startMS = now;
            endMS = now + (int)numericUpDownInterval.Value;
        }

        private void updateFilter()
        {
            long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (now >= endMS)
            {
                resetFilter();
            }
            else
            {
                double progress = (now - startMS) / (double)(endMS - startMS);

                briNow = slerp(briStart, briEnd, progress);
                dsProcess.SetBrightness((float)briNow, (float)briNow, (float)briNow);
                textBoxBri.Text = briNow.ToString("N3");

                conNow = slerp(conStart, conEnd, progress);
                dsProcess.SetContrast((float)conNow, (float)conNow, (float)conNow);
                textBoxCon.Text = conNow.ToString("N3");

                satNow = slerp(satStart, satEnd, progress);
                dsProcess.SetSaturation((float)satNow);
                textBoxSat.Text = satNow.ToString("N3");

                hueNow = slerp(hueStart, hueEnd, progress);
                dsProcess.SetHue((float)hueNow);
                textBoxHue.Text = hueNow.ToString("N3");
            }
        }

        private static double slerp(double start, double end, double x)
        {
            // You better believe I copy-pasted this straight off Wikipedia
            x = x * x * x * (x * (x * 6 - 15) + 10);
            return start + (end - start) * x;
        }
    }
}
