using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace love2dToAPK {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static Forms.frmOutput frmOutput;

        public static string Output {
            get { return _output; }
            set { _output = value; log(value); }
        }
        private static string _output;


        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.firstStart) {
                Forms.frmFirstStartup firstStartupDialog = new Forms.frmFirstStartup();
                firstStartupDialog.ShowDialog();
            }
            Application.Run(new Forms.frmMain());
        }

        private static void log(string str) {
            if (frmOutput != null) {
                frmOutput.log(str);
            }
        }

    }
}
