using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace love2dToAPK.Forms {
    public partial class frmSettings : love2dToAPK.Forms.baseForm {
        public frmSettings() {
            InitializeComponent();

            WindowTitle = "Settings";
            MinimizeAble = false;

            this.TopMost = Properties.Settings.Default.alwaysOnTop;
        }

        private void frmSettings_Load(object sender, EventArgs e) {
            btnSave.BackgroundColor = ColorTranslator.FromHtml("#0fdb0f");

            cbAlwaysOnTop.Checked = Properties.Settings.Default.alwaysOnTop;
            cbCloseOnSuccess.Checked = Properties.Settings.Default.closeOnSuccess;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Properties.Settings.Default.alwaysOnTop = cbAlwaysOnTop.Checked;
            Properties.Settings.Default.closeOnSuccess = cbCloseOnSuccess.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show("Restart the app for changes to take effect.");
            this.Close();
        }
    }
}
