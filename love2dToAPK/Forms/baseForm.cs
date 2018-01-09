using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace love2dToAPK.Forms {

    public partial class baseForm : Form {

        #region localVariables
        Panel overlayPanel;
        #endregion

        #region properties
        public string WindowTitle {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public bool MinimizeAble {
            get { return btnMinimize.Enabled; }
            set {
                if (value) {
                    btnMinimize.Enabled = true;
                    btnMinimize.Show();
                }
                else {
                    btnMinimize.Enabled = false;
                    btnMinimize.Hide();
                }
            }
        }
        #endregion

        #region formShadow
        protected override CreateParams CreateParams {
            get {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        #region formMove
        /* This region contains the code needed to make the form moveable */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void baseForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public baseForm() {
            InitializeComponent();

            /* Add event handlers */
            // These ones are for moving the form
            this.MouseDown += baseForm_MouseDown;
            pnlTitleBar.MouseDown += baseForm_MouseDown;
            pnlFormActions.MouseDown += baseForm_MouseDown;
            lblTitle.MouseDown += baseForm_MouseDown;
            // These are for the button hover effect on the action buttons
            btnClose.MouseEnter += btn_mouseEnter;
            btnClose.MouseLeave += btn_mouseLeave;
            btnMinimize.MouseEnter += btn_mouseEnter;
            btnMinimize.MouseLeave += btn_mouseLeave;
            // These are for the actionButtons
            btnClose.Click += btnClose_Click;
            btnMinimize.Click += btnMinimize_Click;
            // This make the form gray when onactive
            this.EnabledChanged += baseForm_onEnabledChanged;
        }

        #region EventHandlers
        private void btnClose_Click(object sender, EventArgs e) {
            /* Handles the exit-button click */
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e) {
            /* Handles the minimize-button click */
            this.WindowState = FormWindowState.Minimized;
        }

        private void baseForm_onEnabledChanged(object sender, EventArgs e) {
            /* Handles the enable/disable event */
            if (Enabled) {
                this.Controls.Remove(overlayPanel);
                overlayPanel.Dispose();
                overlayPanel = null;
            }
            else {
                overlayPanel = new Panel();
                overlayPanel.Location = new Point(0, 0);
                overlayPanel.Size = new Size(this.Width, this.Height);
                overlayPanel.BackColor = Color.FromArgb(0, 255, 255, 255);
                this.Controls.Add(overlayPanel);
                //overlayPanel.BringToFront();
                this.Invalidate();
            }
        }
        #endregion

        #region ButtonHoverEffect
        public void btn_mouseEnter(object sender, System.EventArgs e) {
            /* This method handles mouseOver event on buttons */
            if (sender is Label) {
                Label thisLabel = (Label)sender;
                //thisLabel.BackColor = Program.UiTheme(thisLabel.Name + "_backgroundHover");
            }
            else if (sender is PictureBox) {
                PictureBox thisPicture = (PictureBox)sender;
                //thisPicture.BackColor = Program.UiTheme(thisPicture.Name + "_backgroundHover");
            }
        }

        public void btn_mouseLeave(object sender, System.EventArgs e) {
            /* This method handles mouseOver event on buttons */
            if (sender is Label) {
                Label thisLabel = (Label)sender;
                //thisLabel.BackColor = Program.UiTheme(thisLabel.Name + "_background");
            }
            else if (sender is PictureBox) {
                PictureBox thisPicture = (PictureBox)sender;
                //thisPicture.BackColor = Program.UiTheme(thisPicture.Name + "_background");
            }
        }
        #endregion

        private void baseForm_Load(object sender, EventArgs e) {
            btnClose.BackgroundColor = ColorTranslator.FromHtml("#ea316e");
            btnMinimize.BackgroundColor = ColorTranslator.FromHtml("#ea316e");
        }

        public virtual void setColor(Color color) {
            pnlTitleBar.BackColor = color;
            pnlFormActions.BackColor = color;
            btnClose.BackgroundColor = color;
            btnMinimize.BackgroundColor = color;
        }
    }

}
