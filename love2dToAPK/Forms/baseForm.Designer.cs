namespace love2dToAPK.Forms {
    partial class baseForm {
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFormActions = new System.Windows.Forms.Panel();
            this.btnMinimize = new love2dToAPK.Controls.minimalButton();
            this.btnClose = new love2dToAPK.Controls.minimalButton();
            this.pnlTitleBar.SuspendLayout();
            this.pnlFormActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.pnlTitleBar.Controls.Add(this.pnlFormActions);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(284, 37);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "<TITLE>";
            // 
            // pnlFormActions
            // 
            this.pnlFormActions.Controls.Add(this.btnMinimize);
            this.pnlFormActions.Controls.Add(this.btnClose);
            this.pnlFormActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFormActions.Location = new System.Drawing.Point(211, 0);
            this.pnlFormActions.Name = "pnlFormActions";
            this.pnlFormActions.Size = new System.Drawing.Size(73, 37);
            this.pnlFormActions.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.btnMinimize.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.ForegroundColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(12, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(1, 5, 2, 5);
            this.btnMinimize.Size = new System.Drawing.Size(23, 35);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(110)))));
            this.btnClose.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ForegroundColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(42, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnClose.Size = new System.Drawing.Size(23, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "baseForm";
            this.Text = "baseForm";
            this.Load += new System.EventHandler(this.baseForm_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlFormActions.ResumeLayout(false);
            this.pnlFormActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlFormActions;
        private System.Windows.Forms.Label lblTitle;
        private Controls.minimalButton btnMinimize;
        private Controls.minimalButton btnClose;
    }
}