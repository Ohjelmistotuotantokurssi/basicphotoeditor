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
            this.tabControlEffects = new System.Windows.Forms.TabControl();
            this.tabPageGrayscale = new System.Windows.Forms.TabPage();
            this.checkBoxGrayscaleToggle = new System.Windows.Forms.CheckBox();
            this.tabPageResize = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControlEffects.SuspendLayout();
            this.tabPageGrayscale.SuspendLayout();
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
            // tabControlEffects
            // 
            this.tabControlEffects.Controls.Add(this.tabPageGrayscale);
            this.tabControlEffects.Controls.Add(this.tabPageResize);
            this.tabControlEffects.Location = new System.Drawing.Point(12, 42);
            this.tabControlEffects.Name = "tabControlEffects";
            this.tabControlEffects.SelectedIndex = 0;
            this.tabControlEffects.Size = new System.Drawing.Size(577, 221);
            this.tabControlEffects.TabIndex = 3;
            // 
            // tabPageGrayscale
            // 
            this.tabPageGrayscale.Controls.Add(this.checkBoxGrayscaleToggle);
            this.tabPageGrayscale.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrayscale.Name = "tabPageGrayscale";
            this.tabPageGrayscale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrayscale.Size = new System.Drawing.Size(569, 195);
            this.tabPageGrayscale.TabIndex = 0;
            this.tabPageGrayscale.Text = "Grayscale";
            this.tabPageGrayscale.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrayscaleToggle
            // 
            this.checkBoxGrayscaleToggle.AutoSize = true;
            this.checkBoxGrayscaleToggle.Location = new System.Drawing.Point(7, 7);
            this.checkBoxGrayscaleToggle.Name = "checkBoxGrayscaleToggle";
            this.checkBoxGrayscaleToggle.Size = new System.Drawing.Size(65, 17);
            this.checkBoxGrayscaleToggle.TabIndex = 0;
            this.checkBoxGrayscaleToggle.Text = "Enabled";
            this.checkBoxGrayscaleToggle.UseVisualStyleBackColor = true;
            this.checkBoxGrayscaleToggle.CheckedChanged += new System.EventHandler(this.onCheckedChanged);
            // 
            // tabPageResize
            // 
            this.tabPageResize.Location = new System.Drawing.Point(4, 22);
            this.tabPageResize.Name = "tabPageResize";
            this.tabPageResize.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResize.Size = new System.Drawing.Size(569, 195);
            this.tabPageResize.TabIndex = 1;
            this.tabPageResize.Text = "Resize";
            this.tabPageResize.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
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
            this.tabControlEffects.ResumeLayout(false);
            this.tabPageGrayscale.ResumeLayout(false);
            this.tabPageGrayscale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxFilepath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabControl tabControlEffects;
        private System.Windows.Forms.TabPage tabPageGrayscale;
        private System.Windows.Forms.CheckBox checkBoxGrayscaleToggle;
        private System.Windows.Forms.TabPage tabPageResize;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

