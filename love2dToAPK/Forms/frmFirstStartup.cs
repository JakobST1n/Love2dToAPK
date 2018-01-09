using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace love2dToAPK.Forms {
    public partial class frmFirstStartup : love2dToAPK.Forms.baseForm {
        public frmFirstStartup() {
            InitializeComponent();

            WindowTitle = "Love2dToAPK";
            MinimizeAble = false;
        }

        private void frmFirstStartup_Load(object sender, EventArgs e) {
            btnContinue.BackgroundColor = ColorTranslator.FromHtml("#0cd10c");
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            Properties.Settings.Default.firstStart = false;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
