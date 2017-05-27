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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxFilepath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPageRotate = new System.Windows.Forms.TabPage();
            this.tabPageHue = new System.Windows.Forms.TabPage();
            this.tabPageBrightContSat = new System.Windows.Forms.TabPage();
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
            this.buttonSave.Location = new System.Drawing.Point(12, 269);
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
            this.tabPageRotate.Location = new System.Drawing.Point(4, 22);
            this.tabPageRotate.Name = "tabPageRotate";
            this.tabPageRotate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRotate.Size = new System.Drawing.Size(569, 195);
            this.tabPageRotate.TabIndex = 4;
            this.tabPageRotate.Text = "Rotate";
            this.tabPageRotate.UseVisualStyleBackColor = true;
            // 
            // tabPageHue
            // 
            this.tabPageHue.Location = new System.Drawing.Point(4, 22);
            this.tabPageHue.Name = "tabPageHue";
            this.tabPageHue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHue.Size = new System.Drawing.Size(569, 195);
            this.tabPageHue.TabIndex = 2;
            this.tabPageHue.Text = "Hue";
            this.tabPageHue.UseVisualStyleBackColor = true;
            // 
            // tabPageBrightContSat
            // 
            this.tabPageBrightContSat.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrightContSat.Name = "tabPageBrightContSat";
            this.tabPageBrightContSat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrightContSat.Size = new System.Drawing.Size(569, 195);
            this.tabPageBrightContSat.TabIndex = 1;
            this.tabPageBrightContSat.Text = "Brightness, Contrast & Saturation";
            this.tabPageBrightContSat.UseVisualStyleBackColor = true;
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
            this.tabPageResize.Size = new System.Drawing.Size(569, 195);
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
            // 
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Location = new System.Drawing.Point(7, 7);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(58, 17);
            this.checkBoxResize.TabIndex = 8;
            this.checkBoxResize.Text = "Resize";
            this.checkBoxResize.UseVisualStyleBackColor = true;
            // 
            // textBoxResizeNewY
            // 
            this.textBoxResizeNewY.Location = new System.Drawing.Point(130, 109);
            this.textBoxResizeNewY.Name = "textBoxResizeNewY";
            this.textBoxResizeNewY.Size = new System.Drawing.Size(100, 20);
            this.textBoxResizeNewY.TabIndex = 7;
            this.textBoxResizeNewY.TextChanged += new System.EventHandler(this.textboxTextChanged);
            // 
            // textBoxResizeNewX
            // 
            this.textBoxResizeNewX.Location = new System.Drawing.Point(6, 109);
            this.textBoxResizeNewX.Name = "textBoxResizeNewX";
            this.textBoxResizeNewX.Size = new System.Drawing.Size(100, 20);
            this.textBoxResizeNewX.TabIndex = 5;
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
            this.tabControlEffects.Size = new System.Drawing.Size(577, 221);
            this.tabControlEffects.TabIndex = 3;
            // 
            // tabPageFilters
            // 
            this.tabPageFilters.Controls.Add(this.checkBoxGrayscale);
            this.tabPageFilters.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilters.Name = "tabPageFilters";
            this.tabPageFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilters.Size = new System.Drawing.Size(569, 195);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 319);
            this.Controls.Add(this.tabControlEffects);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFilepath);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

