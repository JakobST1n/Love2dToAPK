namespace love2dToAPK.Forms {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompile = new love2dToAPK.Controls.minimalButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbStatusImage = new System.Windows.Forms.PictureBox();
            this.btnSelectFolder = new love2dToAPK.Controls.minimalButton();
            this.btnSettings = new love2dToAPK.Controls.minimalButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnToolsFolder = new love2dToAPK.Controls.minimalButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCompile);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnCompile
            // 
            this.btnCompile.AutoSize = true;
            this.btnCompile.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompile.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnCompile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompile.ForeColor = System.Drawing.Color.White;
            this.btnCompile.ForegroundColor = System.Drawing.Color.White;
            this.btnCompile.Location = new System.Drawing.Point(114, 45);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Padding = new System.Windows.Forms.Padding(2);
            this.btnCompile.Size = new System.Drawing.Size(53, 17);
            this.btnCompile.TabIndex = 2;
            this.btnCompile.Text = "Compile";
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.lblStatus.Location = new System.Drawing.Point(71, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 37);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Ready";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.pbStatusImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 70);
            this.panel2.TabIndex = 0;
            // 
            // pbStatusImage
            // 
            this.pbStatusImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStatusImage.Image = global::love2dToAPK.Properties.Resources.ready;
            this.pbStatusImage.Location = new System.Drawing.Point(0, 0);
            this.pbStatusImage.Name = "pbStatusImage";
            this.pbStatusImage.Size = new System.Drawing.Size(70, 70);
            this.pbStatusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusImage.TabIndex = 0;
            this.pbStatusImage.TabStop = false;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.AutoSize = true;
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.btnSelectFolder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.ForeColor = System.Drawing.Color.White;
            this.btnSelectFolder.ForegroundColor = System.Drawing.Color.White;
            this.btnSelectFolder.Location = new System.Drawing.Point(13, 0);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Padding = new System.Windows.Forms.Padding(2);
            this.btnSelectFolder.Size = new System.Drawing.Size(114, 17);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Select project folder";
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.btnSettings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ForegroundColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(131, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(2);
            this.btnSettings.Size = new System.Drawing.Size(53, 17);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.panel3.Controls.Add(this.btnToolsFolder);
            this.panel3.Controls.Add(this.btnSelectFolder);
            this.panel3.Controls.Add(this.btnSettings);
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 17);
            this.panel3.TabIndex = 5;
            // 
            // btnToolsFolder
            // 
            this.btnToolsFolder.AutoSize = true;
            this.btnToolsFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.btnToolsFolder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnToolsFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolsFolder.ForeColor = System.Drawing.Color.White;
            this.btnToolsFolder.ForegroundColor = System.Drawing.Color.White;
            this.btnToolsFolder.Location = new System.Drawing.Point(188, 0);
            this.btnToolsFolder.Name = "btnToolsFolder";
            this.btnToolsFolder.Padding = new System.Windows.Forms.Padding(2);
            this.btnToolsFolder.Size = new System.Drawing.Size(25, 17);
            this.btnToolsFolder.TabIndex = 5;
            this.btnToolsFolder.Text = "dir";
            this.btnToolsFolder.Click += new System.EventHandler(this.btnToolsFolder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(250, 142);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private Controls.minimalButton btnCompile;
        private System.Windows.Forms.PictureBox pbStatusImage;
        private Controls.minimalButton btnSelectFolder;
        private Controls.minimalButton btnSettings;
        private System.Windows.Forms.Panel panel3;
        private Controls.minimalButton btnToolsFolder;
    }
}
