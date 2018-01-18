namespace DS_Retinal_Obliterator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelLoaded = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownHueMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHueMin = new System.Windows.Forms.NumericUpDown();
            this.textBoxHue = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownSatMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSatMin = new System.Windows.Forms.NumericUpDown();
            this.textBoxSat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownConMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConMin = new System.Windows.Forms.NumericUpDown();
            this.textBoxCon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownBriMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBriMin = new System.Windows.Forms.NumericUpDown();
            this.textBoxBri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxActivate = new System.Windows.Forms.CheckBox();
            this.timerCheckProcess = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBriMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBriMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loaded:";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(66, 9);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(33, 13);
            this.labelProcess.TabIndex = 3;
            this.labelProcess.Text = "None";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(66, 22);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(33, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "None";
            // 
            // labelLoaded
            // 
            this.labelLoaded.AutoSize = true;
            this.labelLoaded.Location = new System.Drawing.Point(66, 35);
            this.labelLoaded.Name = "labelLoaded";
            this.labelLoaded.Size = new System.Drawing.Size(21, 13);
            this.labelLoaded.TabIndex = 5;
            this.labelLoaded.Text = "No";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.AutoSize = true;
            this.groupBoxFilter.Controls.Add(this.label20);
            this.groupBoxFilter.Controls.Add(this.label19);
            this.groupBoxFilter.Controls.Add(this.label18);
            this.groupBoxFilter.Controls.Add(this.label17);
            this.groupBoxFilter.Controls.Add(this.label14);
            this.groupBoxFilter.Controls.Add(this.label15);
            this.groupBoxFilter.Controls.Add(this.numericUpDownHueMax);
            this.groupBoxFilter.Controls.Add(this.numericUpDownHueMin);
            this.groupBoxFilter.Controls.Add(this.textBoxHue);
            this.groupBoxFilter.Controls.Add(this.label16);
            this.groupBoxFilter.Controls.Add(this.label11);
            this.groupBoxFilter.Controls.Add(this.label12);
            this.groupBoxFilter.Controls.Add(this.numericUpDownSatMax);
            this.groupBoxFilter.Controls.Add(this.numericUpDownSatMin);
            this.groupBoxFilter.Controls.Add(this.textBoxSat);
            this.groupBoxFilter.Controls.Add(this.label13);
            this.groupBoxFilter.Controls.Add(this.label8);
            this.groupBoxFilter.Controls.Add(this.label9);
            this.groupBoxFilter.Controls.Add(this.numericUpDownConMax);
            this.groupBoxFilter.Controls.Add(this.numericUpDownConMin);
            this.groupBoxFilter.Controls.Add(this.textBoxCon);
            this.groupBoxFilter.Controls.Add(this.label10);
            this.groupBoxFilter.Controls.Add(this.label7);
            this.groupBoxFilter.Controls.Add(this.label6);
            this.groupBoxFilter.Controls.Add(this.numericUpDownBriMax);
            this.groupBoxFilter.Controls.Add(this.numericUpDownBriMin);
            this.groupBoxFilter.Controls.Add(this.textBoxBri);
            this.groupBoxFilter.Controls.Add(this.label5);
            this.groupBoxFilter.Controls.Add(this.numericUpDownInterval);
            this.groupBoxFilter.Controls.Add(this.label4);
            this.groupBoxFilter.Location = new System.Drawing.Point(12, 51);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(384, 227);
            this.groupBoxFilter.TabIndex = 6;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Danger Zone";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(86, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "0 - 360";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(71, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "-100 - 100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(86, 94);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "0 - 100";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(86, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "0 - 100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Maximum";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(129, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Minimum";
            // 
            // numericUpDownHueMax
            // 
            this.numericUpDownHueMax.DecimalPlaces = 2;
            this.numericUpDownHueMax.Location = new System.Drawing.Point(258, 188);
            this.numericUpDownHueMax.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHueMax.Name = "numericUpDownHueMax";
            this.numericUpDownHueMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHueMax.TabIndex = 23;
            this.numericUpDownHueMax.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // numericUpDownHueMin
            // 
            this.numericUpDownHueMin.DecimalPlaces = 2;
            this.numericUpDownHueMin.Location = new System.Drawing.Point(132, 188);
            this.numericUpDownHueMin.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHueMin.Name = "numericUpDownHueMin";
            this.numericUpDownHueMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHueMin.TabIndex = 22;
            // 
            // textBoxHue
            // 
            this.textBoxHue.Location = new System.Drawing.Point(6, 188);
            this.textBoxHue.Name = "textBoxHue";
            this.textBoxHue.ReadOnly = true;
            this.textBoxHue.Size = new System.Drawing.Size(120, 20);
            this.textBoxHue.TabIndex = 21;
            this.textBoxHue.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Hue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Maximum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Minimum";
            // 
            // numericUpDownSatMax
            // 
            this.numericUpDownSatMax.DecimalPlaces = 2;
            this.numericUpDownSatMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownSatMax.Location = new System.Drawing.Point(258, 149);
            this.numericUpDownSatMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownSatMax.Name = "numericUpDownSatMax";
            this.numericUpDownSatMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSatMax.TabIndex = 17;
            this.numericUpDownSatMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownSatMin
            // 
            this.numericUpDownSatMin.DecimalPlaces = 2;
            this.numericUpDownSatMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownSatMin.Location = new System.Drawing.Point(132, 149);
            this.numericUpDownSatMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownSatMin.Name = "numericUpDownSatMin";
            this.numericUpDownSatMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSatMin.TabIndex = 16;
            this.numericUpDownSatMin.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // textBoxSat
            // 
            this.textBoxSat.Location = new System.Drawing.Point(6, 149);
            this.textBoxSat.Name = "textBoxSat";
            this.textBoxSat.ReadOnly = true;
            this.textBoxSat.Size = new System.Drawing.Size(120, 20);
            this.textBoxSat.TabIndex = 15;
            this.textBoxSat.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Saturation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Maximum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Minimum";
            // 
            // numericUpDownConMax
            // 
            this.numericUpDownConMax.DecimalPlaces = 2;
            this.numericUpDownConMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownConMax.Location = new System.Drawing.Point(258, 110);
            this.numericUpDownConMax.Name = "numericUpDownConMax";
            this.numericUpDownConMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownConMax.TabIndex = 11;
            this.numericUpDownConMax.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // numericUpDownConMin
            // 
            this.numericUpDownConMin.DecimalPlaces = 2;
            this.numericUpDownConMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownConMin.Location = new System.Drawing.Point(132, 110);
            this.numericUpDownConMin.Name = "numericUpDownConMin";
            this.numericUpDownConMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownConMin.TabIndex = 10;
            this.numericUpDownConMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // textBoxCon
            // 
            this.textBoxCon.Location = new System.Drawing.Point(6, 110);
            this.textBoxCon.Name = "textBoxCon";
            this.textBoxCon.ReadOnly = true;
            this.textBoxCon.Size = new System.Drawing.Size(120, 20);
            this.textBoxCon.TabIndex = 9;
            this.textBoxCon.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Contrast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Maximum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Minimum";
            // 
            // numericUpDownBriMax
            // 
            this.numericUpDownBriMax.DecimalPlaces = 2;
            this.numericUpDownBriMax.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownBriMax.Location = new System.Drawing.Point(258, 71);
            this.numericUpDownBriMax.Name = "numericUpDownBriMax";
            this.numericUpDownBriMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBriMax.TabIndex = 5;
            this.numericUpDownBriMax.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // numericUpDownBriMin
            // 
            this.numericUpDownBriMin.DecimalPlaces = 2;
            this.numericUpDownBriMin.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownBriMin.Location = new System.Drawing.Point(132, 71);
            this.numericUpDownBriMin.Name = "numericUpDownBriMin";
            this.numericUpDownBriMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBriMin.TabIndex = 4;
            this.numericUpDownBriMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // textBoxBri
            // 
            this.textBoxBri.Location = new System.Drawing.Point(6, 71);
            this.textBoxBri.Name = "textBoxBri";
            this.textBoxBri.ReadOnly = true;
            this.textBoxBri.Size = new System.Drawing.Size(120, 20);
            this.textBoxBri.TabIndex = 3;
            this.textBoxBri.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Brightness";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownInterval.Location = new System.Drawing.Point(6, 32);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInterval.TabIndex = 1;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Interval (ms)";
            // 
            // checkBoxActivate
            // 
            this.checkBoxActivate.AutoSize = true;
            this.checkBoxActivate.Location = new System.Drawing.Point(325, 34);
            this.checkBoxActivate.Name = "checkBoxActivate";
            this.checkBoxActivate.Size = new System.Drawing.Size(65, 17);
            this.checkBoxActivate.TabIndex = 7;
            this.checkBoxActivate.Text = "Activate";
            this.checkBoxActivate.UseVisualStyleBackColor = true;
            this.checkBoxActivate.CheckedChanged += new System.EventHandler(this.checkBoxActivate_CheckedChanged);
            // 
            // timerCheckProcess
            // 
            this.timerCheckProcess.Enabled = true;
            this.timerCheckProcess.Interval = 1000;
            this.timerCheckProcess.Tick += new System.EventHandler(this.timerCheckProcess_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 16;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(408, 289);
            this.Controls.Add(this.checkBoxActivate);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.labelLoaded);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DS Retinal Obliterator <version>";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBriMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBriMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelLoaded;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownHueMax;
        private System.Windows.Forms.NumericUpDown numericUpDownHueMin;
        private System.Windows.Forms.TextBox textBoxHue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownSatMax;
        private System.Windows.Forms.NumericUpDown numericUpDownSatMin;
        private System.Windows.Forms.TextBox textBoxSat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownConMax;
        private System.Windows.Forms.NumericUpDown numericUpDownConMin;
        private System.Windows.Forms.TextBox textBoxCon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownBriMax;
        private System.Windows.Forms.NumericUpDown numericUpDownBriMin;
        private System.Windows.Forms.TextBox textBoxBri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxActivate;
        private System.Windows.Forms.Timer timerCheckProcess;
        private System.Windows.Forms.Timer timerUpdate;
    }
}

