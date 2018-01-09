using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;

namespace love2dToAPK {

    class Compiler {

        public string ProjectPath { get; set; }
        public string ResponseCode { get; set; }

        private string _toolsPath = AppDomain.CurrentDomain.BaseDirectory;
        private string _packageIdentifier;

        public bool BuildSuccessful;
        public Compiler(string projectPath) {
            ProjectPath = projectPath;
            _toolsPath += "//tools//";
        }

        public void compile() {
           /* the actual routine is in compile-routine, this is because we want a nicer looking try-catch thing */
            try {
                compileRoutine();

                log("###############################");
                log("BUILD SUCCESSFULL!!!");
                log("###############################");
                Program.frmOutput.setColor(ColorTranslator.FromHtml("#13c116"));
                SystemSounds.Hand.Play();
                BuildSuccessful = true;

            } catch (Exception e) {
                log("###############################");
                log("BUILD FAILED!!!");
                log("###############################");
                log(e.ToString());
                Program.frmOutput.setColor(ColorTranslator.FromHtml("#e01616"));
                SystemSounds.Asterisk.Play();
                BuildSuccessful = false;

            }
        }

        private void compileRoutine() {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            log("-- Starting compiler --");

            log(">> Checking for required files...");
            requiredFilesExist();

            log(">> Cleaning up old junk...");
            cleanupOldJunk();

            log(">> Getting project settings...");
            extractProjectSettings();

            log(">> Zipping source-dir...");
            ZipFile.CreateFromDirectory(ProjectPath, "tools\\game.love");

            log(">> Putting all the files in the bowl, mixing, and pouring them to different locations.");
            lastPreparationBeforeCompiling();

            log(">> Launching Ant-compiler...");
            runAnt();

            log(">> Move build to build folder...");
            moveOutputFiles();

            log(">> Cleanup...");
            cleanUpNewJunk();

            log(">> Installing on phone");
            moveToPhone();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            log("-- Finished compiling in " + elapsedTime + " --");
        }

        private void requiredFilesExist() {
            /* This method checks if all the required tools and files exist */

            // This directory is required because everything that is needed during the compilation is here
            if (!Directory.Exists("tools")) {
                throw new Exception("TOOLS NOT FOUND; PANICKING! SUPRISE MAFA**A, THERE IS NO CAKE!");
            }

            // This directory is required becuase we want to have something to compile
            if (!Directory.Exists(ProjectPath)) {
                throw new Exception("Project folder not found! \n path at " + ProjectPath);
            }

        }

        private void cleanupOldJunk() {
            /* This method cleans up old files that could be left behind from old compilations */

            // Not really nececarry, just to stop the folder from entering our game.love file
            if (Directory.Exists(ProjectPath + "\\build\\")) {
                log("Buildfolder found, deleting before compiling...");
                Directory.Delete(ProjectPath + "\\build\\", true);
            }

            // Delete old game.love, to stop us from conflicts when zipping the project
            if (File.Exists("tools\\game.love")) {
                log("Deleting old game.love");
                File.Delete("tools\\game.love");
            }

            // Delete old game.apk, this is not really a problem, as we are going to copy it elsewehre anyway
            if (File.Exists("tools\\game.apk")) {
                log("Deleting old game apk");
                File.Delete("tools\\game.apk");
            }

            // Delete old source compilation, again to protect from conflicts
            if (Directory.Exists("tools\\tools\\love-android-sdl2\\src\\love")) {
                log("Deleting old source-folder");
                Directory.Delete("tools\\tools\\love-android-sdl2\\src\\love", true);
            }

            // This is the old game.love file, again, stop from conflicts.
            if (File.Exists("tools\\tools\\love-android-sdl2\\assets\\game.love")) {
                log("Deleting old game apk");
                File.Delete("tools\\tools\\love-android-sdl2\\assets\\game.love");
            }

        }

        private void extractProjectSettings() {
            /* This copies potential custom app settings, and reads things like the app name. 
             * For when we are going to use ADB later */

            // Delete old manifest file, to protect from conflicts
            if (File.Exists(_toolsPath + "tools\\love-android-sdl2\\AndroidManifest.xml")) {
                File.Delete(_toolsPath + "tools\\love-android-sdl2\\AndroidManifest.xml");
            }

            // Copy manifest file from project path if it exists
            // If not we want the default manifest file.
            if (File.Exists(ProjectPath + "\\AndroidManifest.xml")) {
                log("Found manifest file.");
                File.Copy(ProjectPath + "\\AndroidManifest.xml", _toolsPath + "tools\\love-android-sdl2\\AndroidManifest.xml");
            } else {
                log("No maifest file found, using default,");
                File.Copy(_toolsPath + "tools\\love-android-sdl2\\original\\AndroidManifest.xml", _toolsPath + "tools\\love-android-sdl2\\AndroidManifest.xml");
            }

            // We should do something about our icon here as well

            // Read package identifier from the androidManifest
            XmlDocument doc = new XmlDocument();
            doc.Load(_toolsPath + "tools\\love-android-sdl2\\AndroidManifest.xml");
            _packageIdentifier = doc.SelectSingleNode("manifest").Attributes["package"].InnerText;

        }

        private void zipGameSource() {

        }

        private void lastPreparationBeforeCompiling() {
            /* This method will make the sourceDir,
             * get the new game.love file, fiddle with the icon and generate LtaActivityFile */

            // Create the source-dir
            Directory.CreateDirectory("tools\\tools\\love-android-sdl2\\src\\love");
            Directory.CreateDirectory("tools\\tools\\love-android-sdl2\\src\\love\\to");
            Directory.CreateDirectory("tools\\tools\\love-android-sdl2\\src\\love\\to\\android");

            // Fetch the new game.love file
            File.Move("tools\\game.love", "tools\\tools\\love-android-sdl2\\assets\\game.love");
            
            // TODO Move icon to folder, have to make a default as well. Move icon to root in extractProjectSettings

            generateLtaActivityFile();

        }

        private void generateLtaActivityFile() {
            /* I Have no clue what this file really does,
             * but to change the package name we have to generate it
             * instead of just copying it from source */

            string[] lines = {
                "package " + _packageIdentifier + ";",
                "import org.love2d.android.GameActivity;",
                "",
                "public class LtaActivity extends GameActivity {}"
            };
            File.WriteAllLines("tools\\tools\\love-android-sdl2\\src\\love\\to\\android\\LtaActivity.java", lines);

        }

        private void runAnt() {
            /* This runs a batch file that excecutes the compiler-batch-thingy ANT */
            var processInfo = new ProcessStartInfo();
            processInfo.WorkingDirectory = _toolsPath;
            processInfo.FileName = "cmd.exe";
            processInfo.Arguments = "/c startAnt.bat";
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);
            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => log(e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => log("[error] >> " + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            log("Exitcode: " + process.ExitCode.ToString());
            process.Close();
        }

        private void moveOutputFiles() {
            Directory.CreateDirectory(ProjectPath + "\\build\\");
            File.Copy("tools\\tools\\love-android-sdl2\\bin\\love_android_sdl2-debug.apk", ProjectPath + "\\build\\game.apk");
        }

        private void cleanUpNewJunk() {
            File.Delete("tools\\game.love");
            File.Delete("tools\\game.apk");
        }

        private void moveToPhone() {
            adb adb = new adb();

            adb.install(ProjectPath + "\\build\\game.apk");  // This installs the app, if an older version exists, update it.

            log(">> Launching app, please make sure it is unlocked. If it isn't monkey might go crazy!!!");
            Thread.Sleep(1000);
            adb.launchApp(_packageIdentifier);
        }

        private void log(string str) {
            Program.frmOutput.log(str);
        }

    }

}
