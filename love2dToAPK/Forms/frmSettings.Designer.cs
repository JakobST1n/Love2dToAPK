namespace love2dToAPK.Forms {
    partial class frmSettings {
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
            this.cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.cbCloseOnSuccess = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new love2dToAPK.Controls.minimalButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAlwaysOnTop
            // 
            this.cbAlwaysOnTop.AutoSize = true;
            this.cbAlwaysOnTop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlwaysOnTop.Location = new System.Drawing.Point(13, 13);
            this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            this.cbAlwaysOnTop.Size = new System.Drawing.Size(145, 17);
            this.cbAlwaysOnTop.TabIndex = 1;
            this.cbAlwaysOnTop.Text = "Window always on top";
            this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // cbCloseOnSuccess
            // 
            this.cbCloseOnSuccess.AutoSize = true;
            this.cbCloseOnSuccess.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCloseOnSuccess.Location = new System.Drawing.Point(13, 36);
            this.cbCloseOnSuccess.Name = "cbCloseOnSuccess";
            this.cbCloseOnSuccess.Size = new System.Drawing.Size(260, 17);
            this.cbCloseOnSuccess.TabIndex = 2;
            this.cbCloseOnSuccess.Text = "Close output-window if build was successfull";
            this.cbCloseOnSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCloseOnSuccess.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbAlwaysOnTop);
            this.panel1.Controls.Add(this.cbCloseOnSuccess);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 67);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ForegroundColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(239, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(61, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(317, 183);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.Windows.Forms.CheckBox cbCloseOnSuccess;
        private System.Windows.Forms.Panel panel1;
        private Controls.minimalButton btnSave;
    }
}
