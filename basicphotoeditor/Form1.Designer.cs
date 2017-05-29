namespace basicphotoeditor
{
    partial class Form1
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxFilepath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPageRotate = new System.Windows.Forms.TabPage();
            this.labelRotate = new System.Windows.Forms.Label();
            this.trackBarRotate = new System.Windows.Forms.TrackBar();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.tabPageHue = new System.Windows.Forms.TabPage();
            this.checkBoxHueRotate = new System.Windows.Forms.CheckBox();
            this.labelHue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.checkBoxHue = new System.Windows.Forms.CheckBox();
            this.tabPageBrightContSat = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.pictureBoxBrightnessGradient = new System.Windows.Forms.PictureBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.labelContrast = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.labelSaturation = new System.Windows.Forms.Label();
            this.pictureBoxSaturationGradient = new System.Windows.Forms.PictureBox();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.checkBoxColour = new System.Windows.Forms.CheckBox();
            this.tabPageResize = new System.Windows.Forms.TabPage();
            this.labelResizeNewAspect = new System.Windows.Forms.Label();
            this.labelResizeOldAspect = new System.Windows.Forms.Label();
            this.checkBoxResizeLockAspect = new System.Windows.Forms.CheckBox();
            this.checkBoxResize = new System.Windows.Forms.CheckBox();
            this.textBoxResizeNewY = new System.Windows.Forms.TextBox();
            this.textBoxResizeNewX = new System.Windows.Forms.TextBox();
            this.textBoxResizeOrigY = new System.Windows.Forms.TextBox();
            this.textBoxResizeOrigX = new System.Windows.Forms.TextBox();
            this.labelResizeCross2 = new System.Windows.Forms.Label();
            this.labelResizeNew = new System.Windows.Forms.Label();
            this.labelResizeCross = new System.Windows.Forms.Label();
            this.labelResizeOriginal = new System.Windows.Forms.Label();
            this.tabControlEffects = new System.Windows.Forms.TabControl();
            this.tabPageFilters = new System.Windows.Forms.TabPage();
            this.checkBoxGrayscale = new System.Windows.Forms.CheckBox();
            this.toolTipTrackbarValue = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).BeginInit();
            this.tabPageHue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            this.tabPageBrightContSat.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrightnessGradient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaturationGradient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            this.tabPageResize.SuspendLayout();
            this.tabControlEffects.SuspendLayout();
            this.tabPageFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.onClick);
            // 
            // textBoxFilepath
            // 
            this.textBoxFilepath.Location = new System.Drawing.Point(94, 13);
            this.textBoxFilepath.Name = "textBoxFilepath";
            this.textBoxFilepath.ReadOnly = true;
            this.textBoxFilepath.Size = new System.Drawing.Size(495, 20);
            this.textBoxFilepath.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 344);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.onClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // tabPageRotate
            // 
            this.tabPageRotate.Controls.Add(this.labelRotate);
            this.tabPageRotate.Controls.Add(this.trackBarRotate);
            this.tabPageRotate.Controls.Add(this.checkBoxRotate);
            this.tabPageRotate.Location = new System.Drawing.Point(4, 22);
            this.tabPageRotate.Name = "tabPageRotate";
            this.tabPageRotate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRotate.Size = new System.Drawing.Size(569, 270);
            this.tabPageRotate.TabIndex = 4;
            this.tabPageRotate.Text = "Rotate";
            this.tabPageRotate.UseVisualStyleBackColor = true;
            // 
            // labelRotate
            // 
            this.labelRotate.AutoSize = true;
            this.labelRotate.Location = new System.Drawing.Point(9, 46);
            this.labelRotate.Name = "labelRotate";
            this.labelRotate.Size = new System.Drawing.Size(76, 13);
            this.labelRotate.TabIndex = 10;
            this.labelRotate.Text = "Rotation angle";
            // 
            // trackBarRotate
            // 
            this.trackBarRotate.BackColor = System.Drawing.Color.White;
            this.trackBarRotate.CausesValidation = false;
            this.trackBarRotate.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarRotate.LargeChange = 10;
            this.trackBarRotate.Location = new System.Drawing.Point(9, 65);
            this.trackBarRotate.Maximum = 180;
            this.trackBarRotate.Minimum = -180;
            this.trackBarRotate.Name = "trackBarRotate";
            this.trackBarRotate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarRotate.Size = new System.Drawing.Size(554, 45);
            this.trackBarRotate.TabIndex = 9;
            this.trackBarRotate.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(7, 7);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(65, 17);
            this.checkBoxRotate.TabIndex = 0;
            this.checkBoxRotate.Text = "Enabled";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            this.checkBoxRotate.MouseHover += new System.EventHandler(this.checkboxMouseHover);
            // 
            // tabPageHue
            // 
            this.tabPageHue.Controls.Add(this.checkBoxHueRotate);
            this.tabPageHue.Controls.Add(this.labelHue);
            this.tabPageHue.Controls.Add(this.pictureBox1);
            this.tabPageHue.Controls.Add(this.trackBarHue);
            this.tabPageHue.Controls.Add(this.checkBoxHue);
            this.tabPageHue.Location = new System.Drawing.Point(4, 22);
            this.tabPageHue.Name = "tabPageHue";
            this.tabPageHue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHue.Size = new System.Drawing.Size(569, 270);
            this.tabPageHue.TabIndex = 2;
            this.tabPageHue.Text = "Hue";
            this.tabPageHue.UseVisualStyleBackColor = true;
            // 
            // checkBoxHueRotate
            // 
            this.checkBoxHueRotate.AutoSize = true;
            this.checkBoxHueRotate.Location = new System.Drawing.Point(9, 102);
            this.checkBoxHueRotate.Name = "checkBoxHueRotate";
            this.checkBoxHueRotate.Size = new System.Drawing.Size(90, 17);
            this.checkBoxHueRotate.TabIndex = 11;
            this.checkBoxHueRotate.Text = "Rotate Colors";
            this.checkBoxHueRotate.UseVisualStyleBackColor = true;
            this.checkBoxHueRotate.MouseHover += new System.EventHandler(this.checkboxMouseHover);
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(6, 31);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(27, 13);
            this.labelHue.TabIndex = 10;
            this.labelHue.Text = "Hue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::basicphotoeditor.Properties.Resources.gradientHue;
            this.pictureBox1.InitialImage = global::basicphotoeditor.Properties.Resources.gradientHue;
            this.pictureBox1.Location = new System.Drawing.Point(9, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarHue
            // 
            this.trackBarHue.BackColor = System.Drawing.Color.White;
            this.trackBarHue.CausesValidation = false;
            this.trackBarHue.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarHue.LargeChange = 10;
            this.trackBarHue.Location = new System.Drawing.Point(9, 65);
            this.trackBarHue.Maximum = 180;
            this.trackBarHue.Minimum = -180;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarHue.Size = new System.Drawing.Size(554, 45);
            this.trackBarHue.TabIndex = 8;
            this.trackBarHue.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // checkBoxHue
            // 
            this.checkBoxHue.AutoSize = true;
            this.checkBoxHue.Location = new System.Drawing.Point(7, 7);
            this.checkBoxHue.Name = "checkBoxHue";
            this.checkBoxHue.Size = new System.Drawing.Size(65, 17);
            this.checkBoxHue.TabIndex = 0;
            this.checkBoxHue.Text = "Enabled";
            this.checkBoxHue.UseVisualStyleBackColor = true;
            this.checkBoxHue.MouseHover += new System.EventHandler(this.checkboxMouseHover);
            // 
            // tabPageBrightContSat
            // 
            this.tabPageBrightContSat.Controls.Add(this.flowLayoutPanel1);
            this.tabPageBrightContSat.Controls.Add(this.checkBoxColour);
            this.tabPageBrightContSat.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrightContSat.Name = "tabPageBrightContSat";
            this.tabPageBrightContSat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrightContSat.Size = new System.Drawing.Size(569, 270);
            this.tabPageBrightContSat.TabIndex = 1;
            this.tabPageBrightContSat.Text = "Brightness, Contrast & Saturation";
            this.tabPageBrightContSat.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelBrightness);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxBrightnessGradient);
            this.flowLayoutPanel1.Controls.Add(this.trackBarBrightness);
            this.flowLayoutPanel1.Controls.Add(this.labelContrast);
            this.flowLayoutPanel1.Controls.Add(this.trackBarContrast);
            this.flowLayoutPanel1.Controls.Add(this.labelSaturation);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxSaturationGradient);
            this.flowLayoutPanel1.Controls.Add(this.trackBarSaturation);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(569, 240);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(3, 0);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(56, 13);
            this.labelBrightness.TabIndex = 1;
            this.labelBrightness.Text = "Brightness";
            // 
            // pictureBoxBrightnessGradient
            // 
            this.pictureBoxBrightnessGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBrightnessGradient.Image = global::basicphotoeditor.Properties.Resources.gradientBrightness;
            this.pictureBoxBrightnessGradient.InitialImage = global::basicphotoeditor.Properties.Resources.gradientBrightness;
            this.pictureBoxBrightnessGradient.Location = new System.Drawing.Point(10, 16);
            this.pictureBoxBrightnessGradient.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pictureBoxBrightnessGradient.Name = "pictureBoxBrightnessGradient";
            this.pictureBoxBrightnessGradient.Size = new System.Drawing.Size(552, 13);
            this.pictureBoxBrightnessGradient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBrightnessGradient.TabIndex = 7;
            this.pictureBoxBrightnessGradient.TabStop = false;
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.BackColor = System.Drawing.Color.White;
            this.trackBarBrightness.CausesValidation = false;
            this.trackBarBrightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarBrightness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarBrightness.LargeChange = 10;
            this.trackBarBrightness.Location = new System.Drawing.Point(3, 35);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = -100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarBrightness.Size = new System.Drawing.Size(566, 45);
            this.trackBarBrightness.TabIndex = 2;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // labelContrast
            // 
            this.labelContrast.AutoSize = true;
            this.labelContrast.Location = new System.Drawing.Point(3, 83);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(46, 13);
            this.labelContrast.TabIndex = 3;
            this.labelContrast.Text = "Contrast";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.BackColor = System.Drawing.Color.White;
            this.trackBarContrast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarContrast.LargeChange = 10;
            this.trackBarContrast.Location = new System.Drawing.Point(3, 99);
            this.trackBarContrast.Maximum = 100;
            this.trackBarContrast.Minimum = -100;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(566, 45);
            this.trackBarContrast.TabIndex = 4;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // labelSaturation
            // 
            this.labelSaturation.AutoSize = true;
            this.labelSaturation.Location = new System.Drawing.Point(3, 147);
            this.labelSaturation.Name = "labelSaturation";
            this.labelSaturation.Size = new System.Drawing.Size(55, 13);
            this.labelSaturation.TabIndex = 4;
            this.labelSaturation.Text = "Saturation";
            // 
            // pictureBoxSaturationGradient
            // 
            this.pictureBoxSaturationGradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSaturationGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSaturationGradient.Image = global::basicphotoeditor.Properties.Resources.gradientSaturation;
            this.pictureBoxSaturationGradient.InitialImage = global::basicphotoeditor.Properties.Resources.gradientSaturation;
            this.pictureBoxSaturationGradient.Location = new System.Drawing.Point(10, 163);
            this.pictureBoxSaturationGradient.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pictureBoxSaturationGradient.Name = "pictureBoxSaturationGradient";
            this.pictureBoxSaturationGradient.Size = new System.Drawing.Size(552, 13);
            this.pictureBoxSaturationGradient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSaturationGradient.TabIndex = 6;
            this.pictureBoxSaturationGradient.TabStop = false;
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.BackColor = System.Drawing.Color.White;
            this.trackBarSaturation.LargeChange = 10;
            this.trackBarSaturation.Location = new System.Drawing.Point(3, 182);
            this.trackBarSaturation.Maximum = 100;
            this.trackBarSaturation.Minimum = -100;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(566, 45);
            this.trackBarSaturation.TabIndex = 6;
            this.trackBarSaturation.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // checkBoxColour
            // 
            this.checkBoxColour.AutoSize = true;
            this.checkBoxColour.Location = new System.Drawing.Point(7, 7);
            this.checkBoxColour.Name = "checkBoxColour";
            this.checkBoxColour.Size = new System.Drawing.Size(65, 17);
            this.checkBoxColour.TabIndex = 0;
            this.checkBoxColour.Text = "Enabled";
            this.checkBoxColour.UseVisualStyleBackColor = true;
            this.checkBoxColour.MouseHover += new System.EventHandler(this.checkboxMouseHover);
            // 
            // tabPageResize
            // 
            this.tabPageResize.Controls.Add(this.labelResizeNewAspect);
            this.tabPageResize.Controls.Add(this.labelResizeOldAspect);
            this.tabPageResize.Controls.Add(this.checkBoxResizeLockAspect);
            this.tabPageResize.Controls.Add(this.checkBoxResize);
            this.tabPageResize.Controls.Add(this.textBoxResizeNewY);
            this.tabPageResize.Controls.Add(this.textBoxResizeNewX);
            this.tabPageResize.Controls.Add(this.textBoxResizeOrigY);
            this.tabPageResize.Controls.Add(this.textBoxResizeOrigX);
            this.tabPageResize.Controls.Add(this.labelResizeCross2);
            this.tabPageResize.Controls.Add(this.labelResizeNew);
            this.tabPageResize.Controls.Add(this.labelResizeCross);
            this.tabPageResize.Controls.Add(this.labelResizeOriginal);
            this.tabPageResize.Location = new System.Drawing.Point(4, 22);
            this.tabPageResize.Name = "tabPageResize";
            this.tabPageResize.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResize.Size = new System.Drawing.Size(569, 270);
            this.tabPageResize.TabIndex = 3;
            this.tabPageResize.Text = "Resize";
            this.tabPageResize.UseVisualStyleBackColor = true;
            // 
            // labelResizeNewAspect
            // 
            this.labelResizeNewAspect.AutoSize = true;
            this.labelResizeNewAspect.Location = new System.Drawing.Point(236, 112);
            this.labelResizeNewAspect.Name = "labelResizeNewAspect";
            this.labelResizeNewAspect.Size = new System.Drawing.Size(22, 13);
            this.labelResizeNewAspect.TabIndex = 11;
            this.labelResizeNewAspect.Text = "1:1";
            // 
            // labelResizeOldAspect
            // 
            this.labelResizeOldAspect.AutoSize = true;
            this.labelResizeOldAspect.Location = new System.Drawing.Point(238, 52);
            this.labelResizeOldAspect.Name = "labelResizeOldAspect";
            this.labelResizeOldAspect.Size = new System.Drawing.Size(22, 13);
            this.labelResizeOldAspect.TabIndex = 10;
            this.labelResizeOldAspect.Text = "1:1";
            // 
            // checkBoxResizeLockAspect
            // 
            this.checkBoxResizeLockAspect.AutoSize = true;
            this.checkBoxResizeLockAspect.Location = new System.Drawing.Point(112, 80);
            this.checkBoxResizeLockAspect.Name = "checkBoxResizeLockAspect";
            this.checkBoxResizeLockAspect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxResizeLockAspect.Size = new System.Drawing.Size(124, 17);
            this.checkBoxResizeLockAspect.TabIndex = 9;
            this.checkBoxResizeLockAspect.Text = "Maintain aspect ratio";
            this.checkBoxResizeLockAspect.UseVisualStyleBackColor = true;
            this.checkBoxResizeLockAspect.CheckedChanged += new System.EventHandler(this.checkboxCheckedChanged);
            this.checkBoxResizeLockAspect.MouseHover += new System.EventHandler(this.checkboxMouseHover);
            // 
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Location = new System.Drawing.Point(7, 7);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(65, 17);
            this.checkBoxResize.TabIndex = 8;
            this.checkBoxResize.Text = "Enabled";
            this.checkBoxResize.UseVisualStyleBackColor = true;
            this.checkBoxResize.MouseHover += new System.EventHandler(this.checkboxMouseHover);
            // 
            // textBoxResizeNewY
            // 
            this.textBoxResizeNewY.Location = new System.Drawing.Point(130, 109);
            this.textBoxResizeNewY.Name = "textBoxResizeNewY";
            this.textBoxResizeNewY.Size = new System.Drawing.Size(100, 20);
            this.textBoxResizeNewY.TabIndex = 7;
            this.textBoxResizeNewY.TextChanged += new System.EventHandler(this.textboxTextChanged);
            this.textBoxResizeNewY.MouseHover += new System.EventHandler(this.textBoxMouseHover);
            // 
            // textBoxResizeNewX
            // 
            this.textBoxResizeNewX.Location = new System.Drawing.Point(6, 109);
            this.textBoxResizeNewX.Name = "textBoxResizeNewX";
            this.textBoxResizeNewX.Size = new System.Drawing.Size(100, 20);
            this.textBoxResizeNewX.TabIndex = 5;
            this.textBoxResizeNewX.TextChanged += new System.EventHandler(this.textboxTextChanged);
            this.textBoxResizeNewX.MouseHover += new System.EventHandler(this.textBoxMouseHover);
            // 
            // textBoxResizeOrigY
            // 
            this.textBoxResizeOrigY.Enabled = false;
            this.textBoxResizeOrigY.Location = new System.Drawing.Point(132, 49);
            this.textBoxResizeOrigY.Name = "textBoxResizeOrigY";
            this.textBoxResizeOrigY.Size = new System.Drawing.Size(100, 20);
            this.textBoxResizeOrigY.TabIndex = 2;
            // 
            // textBoxResizeOrigX
            // 
            this.textBoxResizeOrigX.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResizeOrigX.Enabled = false;
            this.textBoxResizeOrigX.Location = new System.Drawing.Point(6, 49);
            this.textBoxResizeOrigX.Name = "textBoxResizeOrigX";
            this.textBoxResizeOrigX.Size = new System.Drawing.Size(100, 20);
            this.textBoxResizeOrigX.TabIndex = 1;
            // 
            // labelResizeCross2
            // 
            this.labelResizeCross2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResizeCross2.AutoSize = true;
            this.labelResizeCross2.Location = new System.Drawing.Point(112, 112);
            this.labelResizeCross2.Name = "labelResizeCross2";
            this.labelResizeCross2.Size = new System.Drawing.Size(12, 13);
            this.labelResizeCross2.TabIndex = 6;
            this.labelResizeCross2.Text = "x";
            this.labelResizeCross2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResizeNew
            // 
            this.labelResizeNew.AutoSize = true;
            this.labelResizeNew.Location = new System.Drawing.Point(3, 92);
            this.labelResizeNew.Name = "labelResizeNew";
            this.labelResizeNew.Size = new System.Drawing.Size(53, 13);
            this.labelResizeNew.TabIndex = 4;
            this.labelResizeNew.Text = "New size:";
            // 
            // labelResizeCross
            // 
            this.labelResizeCross.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResizeCross.AutoSize = true;
            this.labelResizeCross.Location = new System.Drawing.Point(112, 52);
            this.labelResizeCross.Name = "labelResizeCross";
            this.labelResizeCross.Size = new System.Drawing.Size(12, 13);
            this.labelResizeCross.TabIndex = 3;
            this.labelResizeCross.Text = "x";
            this.labelResizeCross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResizeOriginal
            // 
            this.labelResizeOriginal.AutoSize = true;
            this.labelResizeOriginal.Location = new System.Drawing.Point(3, 32);
            this.labelResizeOriginal.Name = "labelResizeOriginal";
            this.labelResizeOriginal.Size = new System.Drawing.Size(66, 13);
            this.labelResizeOriginal.TabIndex = 0;
            this.labelResizeOriginal.Text = "Original size:";
            this.labelResizeOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlEffects
            // 
            this.tabControlEffects.Controls.Add(this.tabPageFilters);
            this.tabControlEffects.Controls.Add(this.tabPageResize);
            this.tabControlEffects.Controls.Add(this.tabPageBrightContSat);
            this.tabControlEffects.Controls.Add(this.tabPageHue);
            this.tabControlEffects.Controls.Add(this.tabPageRotate);
            this.tabControlEffects.Location = new System.Drawing.Point(12, 42);
            this.tabControlEffects.Name = "tabControlEffects";
            this.tabControlEffects.SelectedIndex = 0;
            this.tabControlEffects.Size = new System.Drawing.Size(577, 296);
            this.tabControlEffects.TabIndex = 3;
            // 
            // tabPageFilters
            // 
            this.tabPageFilters.Controls.Add(this.checkBoxGrayscale);
            this.tabPageFilters.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilters.Name = "tabPageFilters";
            this.tabPageFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilters.Size = new System.Drawing.Size(569, 270);
            this.tabPageFilters.TabIndex = 0;
            this.tabPageFilters.Text = "Filters";
            this.tabPageFilters.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrayscale
            // 
            this.checkBoxGrayscale.AutoSize = true;
            this.checkBoxGrayscale.Location = new System.Drawing.Point(7, 7);
            this.checkBoxGrayscale.Name = "checkBoxGrayscale";
            this.checkBoxGrayscale.Size = new System.Drawing.Size(73, 17);
            this.checkBoxGrayscale.TabIndex = 0;
            this.checkBoxGrayscale.Text = "Grayscale";
            this.checkBoxGrayscale.UseVisualStyleBackColor = true;
            this.checkBoxGrayscale.MouseHover += new System.EventHandler(this.checkboxMouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 379);
            this.Controls.Add(this.tabControlEffects);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFilepath);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPageRotate.ResumeLayout(false);
            this.tabPageRotate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotate)).EndInit();
            this.tabPageHue.ResumeLayout(false);
            this.tabPageHue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            this.tabPageBrightContSat.ResumeLayout(false);
            this.tabPageBrightContSat.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrightnessGradient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaturationGradient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            this.tabPageResize.ResumeLayout(false);
            this.tabPageResize.PerformLayout();
            this.tabControlEffects.ResumeLayout(false);
            this.tabPageFilters.ResumeLayout(false);
            this.tabPageFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxFilepath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPageRotate;
        private System.Windows.Forms.TabPage tabPageHue;
        private System.Windows.Forms.TabPage tabPageBrightContSat;
        private System.Windows.Forms.TabPage tabPageResize;
        private System.Windows.Forms.CheckBox checkBoxResize;
        private System.Windows.Forms.TextBox textBoxResizeNewY;
        private System.Windows.Forms.TextBox textBoxResizeNewX;
        private System.Windows.Forms.TextBox textBoxResizeOrigY;
        private System.Windows.Forms.TextBox textBoxResizeOrigX;
        private System.Windows.Forms.Label labelResizeCross2;
        private System.Windows.Forms.Label labelResizeNew;
        private System.Windows.Forms.Label labelResizeCross;
        private System.Windows.Forms.Label labelResizeOriginal;
        private System.Windows.Forms.TabControl tabControlEffects;
        private System.Windows.Forms.TabPage tabPageFilters;
        private System.Windows.Forms.CheckBox checkBoxGrayscale;
        private System.Windows.Forms.Label labelResizeNewAspect;
        private System.Windows.Forms.Label labelResizeOldAspect;
        private System.Windows.Forms.CheckBox checkBoxResizeLockAspect;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.CheckBox checkBoxColour;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.Label labelSaturation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxSaturationGradient;
        private System.Windows.Forms.PictureBox pictureBoxBrightnessGradient;
        private System.Windows.Forms.ToolTip toolTipTrackbarValue;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.CheckBox checkBoxHue;
        private System.Windows.Forms.TrackBar trackBarRotate;
        private System.Windows.Forms.CheckBox checkBoxRotate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Label labelRotate;
        private System.Windows.Forms.CheckBox checkBoxHueRotate;
        private System.Windows.Forms.ToolTip toolTipInfo;
    }
}

