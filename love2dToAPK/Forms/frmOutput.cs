using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms;

namespace love2dToAPK.Forms {
    public partial class frmOutput : love2dToAPK.Forms.baseForm {

        public string projectPath { get; set; }
        public string responseCode { get; set; }

        private Thread _compilerThread;
        private string _toolsPath = AppDomain.CurrentDomain.BaseDirectory;

        public frmOutput() {
            InitializeComponent();

            WindowTitle = "Output";
            MinimizeAble = false;
            txtOutput.ScrollBars = ScrollBars.Vertical;
        }

        private void frmOutput_Load(object sender, EventArgs e) {
            _compilerThread = new Thread(compileRoutine);
            _compilerThread.Start();

            this.TopMost = Properties.Settings.Default.alwaysOnTop;
        }

        private void compileRoutine() {
            Compiler compiler = new Compiler(projectPath);
            compiler.compile();
            
            if (compiler.BuildSuccessful && Properties.Settings.Default.closeOnSuccess) {
                this.Invoke((MethodInvoker)delegate {
                    this.Close();
                });
            }
        }

        public void log(string str) {
            if (InvokeRequired) {
                this.Invoke(new Action<string>(log), new object[] { str });
                return;
            }
            txtOutput.AppendText(str + "\r\n");
        }

    }
}
