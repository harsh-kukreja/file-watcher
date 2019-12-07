namespace Intrusion_Detection_System
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
            this.watchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.watchFile = new System.Windows.Forms.RadioButton();
            this.watchFolder = new System.Windows.Forms.RadioButton();
            this.includeSubCheckbox = new System.Windows.Forms.CheckBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.logTextbox = new System.Windows.Forms.RichTextBox();
            this.pathTextBox = new System.Windows.Forms.RichTextBox();
            this.dumpBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // watchBtn
            // 
            this.watchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.watchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.watchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchBtn.Location = new System.Drawing.Point(30, 194);
            this.watchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(95, 24);
            this.watchBtn.TabIndex = 2;
            this.watchBtn.Text = "Watch";
            this.watchBtn.UseVisualStyleBackColor = false;
            this.watchBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.watchFile);
            this.groupBox1.Controls.Add(this.watchFolder);
            this.groupBox1.Controls.Add(this.includeSubCheckbox);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(30, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // watchFile
            // 
            this.watchFile.AutoSize = true;
            this.watchFile.ForeColor = System.Drawing.Color.Black;
            this.watchFile.Location = new System.Drawing.Point(6, 19);
            this.watchFile.Name = "watchFile";
            this.watchFile.Size = new System.Drawing.Size(81, 17);
            this.watchFile.TabIndex = 1;
            this.watchFile.TabStop = true;
            this.watchFile.Text = "Watch Files";
            this.watchFile.UseVisualStyleBackColor = true;
            this.watchFile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // watchFolder
            // 
            this.watchFolder.AutoSize = true;
            this.watchFolder.ForeColor = System.Drawing.Color.Black;
            this.watchFolder.Location = new System.Drawing.Point(6, 50);
            this.watchFolder.Name = "watchFolder";
            this.watchFolder.Size = new System.Drawing.Size(89, 17);
            this.watchFolder.TabIndex = 1;
            this.watchFolder.TabStop = true;
            this.watchFolder.Text = "Watch Folder";
            this.watchFolder.UseVisualStyleBackColor = true;
            // 
            // includeSubCheckbox
            // 
            this.includeSubCheckbox.AutoSize = true;
            this.includeSubCheckbox.ForeColor = System.Drawing.Color.Black;
            this.includeSubCheckbox.Location = new System.Drawing.Point(106, 50);
            this.includeSubCheckbox.Name = "includeSubCheckbox";
            this.includeSubCheckbox.Size = new System.Drawing.Size(131, 17);
            this.includeSubCheckbox.TabIndex = 0;
            this.includeSubCheckbox.Text = "Include Subdirectories";
            this.includeSubCheckbox.UseVisualStyleBackColor = true;
            this.includeSubCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(299, 144);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(96, 27);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.Browse_Click);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(29, 262);
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.Size = new System.Drawing.Size(366, 151);
            this.logTextbox.TabIndex = 5;
            this.logTextbox.Text = "";
            // 
            // pathTextBox
            // 
            this.pathTextBox.EnableAutoDragDrop = true;
            this.pathTextBox.Location = new System.Drawing.Point(29, 151);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(243, 19);
            this.pathTextBox.TabIndex = 6;
            this.pathTextBox.Text = "";
            // 
            // dumpBtn
            // 
            this.dumpBtn.Location = new System.Drawing.Point(36, 442);
            this.dumpBtn.Name = "dumpBtn";
            this.dumpBtn.Size = new System.Drawing.Size(107, 25);
            this.dumpBtn.TabIndex = 7;
            this.dumpBtn.Text = "Dump To Log";
            this.dumpBtn.UseVisualStyleBackColor = true;
            this.dumpBtn.Click += new System.EventHandler(this.dumpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 493);
            this.Controls.Add(this.dumpBtn);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.watchBtn);
            this.Name = "Form1";
            this.Text = "FileWatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button watchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox includeSubCheckbox;
        private System.Windows.Forms.RadioButton watchFolder;
        private System.Windows.Forms.RadioButton watchFile;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.RichTextBox logTextbox;
        private System.Windows.Forms.RichTextBox pathTextBox;
        private System.Windows.Forms.Button dumpBtn;
    }
}

