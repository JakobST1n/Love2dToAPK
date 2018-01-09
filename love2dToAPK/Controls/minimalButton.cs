using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace love2dToAPK.Controls {
    public partial class minimalButton : System.Windows.Forms.Label {

        public Color BackgroundColor {
            get { return colorStates[0]; }
            set { generateColors(value); }
        }
        public Color ForegroundColor {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        private Color[] colorStates;

        public minimalButton() {
            InitializeComponent();

            // Bind eventHandlers
            this.MouseEnter += onMouseEnter;
            this.MouseLeave += onMouseLeave;
            this.MouseDown += onMouseDown;
            this.MouseUp += onMouseUp;

            // Generate colors
            ForegroundColor = this.ForeColor;
            BackgroundColor = this.BackColor;
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }

        private void onMouseEnter(object sender, System.EventArgs e) {
            this.BackColor = colorStates[1];
        }

        private void onMouseLeave(object sender, System.EventArgs e) {
            this.BackColor = colorStates[0];
        }

        private void onMouseDown(object sender, System.EventArgs e) {
            this.BackColor = colorStates[2];
        }

        private void onMouseUp(object sender, System.EventArgs e) {
            this.BackColor = colorStates[1];
        }

        private void generateColors(Color buttonColor) {
            colorStates = new Color[3];
            colorStates[0] = buttonColor;
            colorStates[1] = Color.FromArgb(buttonColor.R + 10, buttonColor.G + 10, buttonColor.B + 10);
            colorStates[2] = Color.FromArgb(buttonColor.R - 10, buttonColor.G - 10, buttonColor.B - 10);
            //colorStates[1] = buttonColor;
            //colorStates[2] = buttonColor;
            this.BackColor = buttonColor;
        }

    }
}
