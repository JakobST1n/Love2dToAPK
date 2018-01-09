using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace love2dToAPK {

    class adb {
        
        public adb() {
        }

        public void install(string apkPath) {
            var processInfo = new ProcessStartInfo();
            processInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "tools\\tools\\adb";
            processInfo.FileName = "cmd.exe";
            processInfo.Arguments = "/c adb.exe install -r \"" + apkPath + "\"";  // This will install a new version of the app
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);
            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => log(e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => log("error>> " + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            //Console.WriteLine("ExitCode: {0}", process.ExitCode);
            log("Exitcode: " + process.ExitCode.ToString());
            process.Close();
            return;
        }

        public void uninstall(string bundleIdentifier) {
            var processInfo = new ProcessStartInfo();
            processInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "tools\\tools\\adb";
            processInfo.FileName = "cmd.exe";
            processInfo.Arguments = "/c adb.exe uninstall \"" + bundleIdentifier + "\"";
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);
            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => log(e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => log("error>> " + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            //Console.WriteLine("ExitCode: {0}", process.ExitCode);
            log("Exitcode: " + process.ExitCode.ToString());
            process.Close();
            return;
        }

        public void launchApp(string bundleIdentifier) {
            var processInfo = new ProcessStartInfo();
            processInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "tools\\tools\\adb";
            processInfo.FileName = "cmd.exe";
            processInfo.Arguments = "/c adb.exe shell monkey -p " + bundleIdentifier + " -c android.intent.category.LAUNCHER 1";
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);
            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => log(e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => log("error>> " + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            //Console.WriteLine("ExitCode: {0}", process.ExitCode);
            log("Exitcode: " + process.ExitCode.ToString());
            process.Close();
            return;
        }

        private void log(string str) {
            Program.frmOutput.log(str);
        }

    }

}
