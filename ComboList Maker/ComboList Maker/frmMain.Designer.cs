namespace ComboList_Maker
{
    partial class frmMain
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
            this.gbIO = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbPasswords = new System.Windows.Forms.TextBox();
            this.tbUsernames = new System.Windows.Forms.TextBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbDelimiter = new System.Windows.Forms.TextBox();
            this.tbLineBreak = new System.Windows.Forms.TextBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.pbCombine = new System.Windows.Forms.ProgressBar();
            this.lblWatermark = new System.Windows.Forms.Label();
            this.gbIO.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIO
            // 
            this.gbIO.Controls.Add(this.tbOutput);
            this.gbIO.Controls.Add(this.tbPasswords);
            this.gbIO.Controls.Add(this.tbUsernames);
            this.gbIO.Location = new System.Drawing.Point(14, 13);
            this.gbIO.Name = "gbIO";
            this.gbIO.Size = new System.Drawing.Size(297, 102);
            this.gbIO.TabIndex = 0;
            this.gbIO.TabStop = false;
            this.gbIO.Text = "File Paths:";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(6, 72);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(285, 20);
            this.tbOutput.TabIndex = 2;
            this.tbOutput.DoubleClick += new System.EventHandler(this.tbOutput_DoubleClick);
            // 
            // tbPasswords
            // 
            this.tbPasswords.Location = new System.Drawing.Point(6, 46);
            this.tbPasswords.Name = "tbPasswords";
            this.tbPasswords.ReadOnly = true;
            this.tbPasswords.Size = new System.Drawing.Size(285, 20);
            this.tbPasswords.TabIndex = 1;
            this.tbPasswords.Text = "Select Passwords...";
            this.tbPasswords.DoubleClick += new System.EventHandler(this.tbPasswords_DoubleClick);
            // 
            // tbUsernames
            // 
            this.tbUsernames.Location = new System.Drawing.Point(6, 20);
            this.tbUsernames.Name = "tbUsernames";
            this.tbUsernames.ReadOnly = true;
            this.tbUsernames.Size = new System.Drawing.Size(285, 20);
            this.tbUsernames.TabIndex = 0;
            this.tbUsernames.Text = "Select Usernames...";
            this.tbUsernames.DoubleClick += new System.EventHandler(this.tbUsernames_DoubleClick);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.lblSettings);
            this.gbSettings.Controls.Add(this.tbLineBreak);
            this.gbSettings.Controls.Add(this.tbDelimiter);
            this.gbSettings.Location = new System.Drawing.Point(14, 121);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(179, 70);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings:";
            // 
            // tbDelimiter
            // 
            this.tbDelimiter.Location = new System.Drawing.Point(68, 13);
            this.tbDelimiter.Name = "tbDelimiter";
            this.tbDelimiter.Size = new System.Drawing.Size(100, 20);
            this.tbDelimiter.TabIndex = 0;
            this.tbDelimiter.Text = ":";
            // 
            // tbLineBreak
            // 
            this.tbLineBreak.Location = new System.Drawing.Point(68, 39);
            this.tbLineBreak.Name = "tbLineBreak";
            this.tbLineBreak.Size = new System.Drawing.Size(100, 20);
            this.tbLineBreak.TabIndex = 1;
            this.tbLineBreak.Text = "System";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(6, 16);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(61, 39);
            this.lblSettings.TabIndex = 2;
            this.lblSettings.Text = "Delimiter:\r\n\r\nLine Break:";
            // 
            // btnCombine
            // 
            this.btnCombine.Location = new System.Drawing.Point(199, 132);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(106, 23);
            this.btnCombine.TabIndex = 2;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // pbCombine
            // 
            this.pbCombine.Location = new System.Drawing.Point(14, 197);
            this.pbCombine.Name = "pbCombine";
            this.pbCombine.Size = new System.Drawing.Size(297, 23);
            this.pbCombine.TabIndex = 3;
            // 
            // lblWatermark
            // 
            this.lblWatermark.AutoSize = true;
            this.lblWatermark.Location = new System.Drawing.Point(216, 167);
            this.lblWatermark.Name = "lblWatermark";
            this.lblWatermark.Size = new System.Drawing.Size(76, 13);
            this.lblWatermark.TabIndex = 4;
            this.lblWatermark.Text = "StarLabs 2025";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 228);
            this.Controls.Add(this.lblWatermark);
            this.Controls.Add(this.pbCombine);
            this.Controls.Add(this.btnCombine);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Combolist Maker | StarLabs";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbIO.ResumeLayout(false);
            this.gbIO.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIO;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbPasswords;
        private System.Windows.Forms.TextBox tbUsernames;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.TextBox tbLineBreak;
        private System.Windows.Forms.TextBox tbDelimiter;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.ProgressBar pbCombine;
        private System.Windows.Forms.Label lblWatermark;
    }
}

