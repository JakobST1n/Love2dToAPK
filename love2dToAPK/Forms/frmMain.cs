using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace love2dToAPK.Forms {
    public partial class frmMain : love2dToAPK.Forms.baseForm {

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MOD_CONTROL = 0x0002;
        const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;


        public frmMain() {
            InitializeComponent();

            WindowTitle = "Love2dToAPK";
            RegisterHotKey(this.Handle, 1, MOD_CONTROL + MOD_SHIFT, (int)Keys.F5);
        }

        private void frmMain_Load(object sender, EventArgs e) {
            btnCompile.BackgroundColor = ColorTranslator.FromHtml("#ea316e");
            btnSelectFolder.BackgroundColor = ColorTranslator.FromHtml("#ea316e");
            btnSettings.BackgroundColor = ColorTranslator.FromHtml("#ea316e");
            btnToolsFolder.BackgroundColor = ColorTranslator.FromHtml("#ea316e");

            this.TopMost = Properties.Settings.Default.alwaysOnTop;
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
                compileRoutine();
            base.WndProc(ref m);
        }

        private void btnCompile_Click(object sender, EventArgs e) {
            compileRoutine();
        }

        private void compileRoutine() {
            // Open output console, deactivate self, reactivate self
            this.lblStatus.Text = "Compiling...";
            this.Enabled = false;
            Forms.frmOutput dlg = new Forms.frmOutput();
            Program.frmOutput = dlg;
            dlg.projectPath = Properties.Settings.Default.projectPath;
            DialogResult result = dlg.ShowDialog();
            Program.frmOutput = null;
            this.Enabled = true;
            this.lblStatus.Text = "Ready";
        }

        private void btnSelectFolder_Click(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            //dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                Properties.Settings.Default.projectPath = dialog.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            this.Enabled = false;
            Forms.frmSettings dlg = new Forms.frmSettings();
            dlg.ShowDialog();
            this.Enabled = true;
        }

        private void btnToolsFolder_Click(object sender, EventArgs e) {
            if (!Directory.Exists("tools")) {
                Directory.CreateDirectory("tools");
            }
            Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory + "tools");
        }
    }
}
