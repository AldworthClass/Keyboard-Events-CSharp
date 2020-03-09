using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Events_CSharp
{
    public partial class FormKeyboard : Form
    {
        public FormKeyboard()
        {
            InitializeComponent();
        }

        private void FormKeyboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                lblKeyInfo.Text = "Up Arrow Pressed";
            else if (e.KeyCode == Keys.Down)
                lblKeyInfo.Text = "Down Arrow Pressed";
            else if (e.KeyCode == Keys.Left)
                lblKeyInfo.Text = "Left Arrow Pressed";
            else if (e.KeyCode == Keys.Right)
                lblKeyInfo.Text = "Right Arrow Pressed";
            else if (e.KeyCode == Keys.B)
            {
                lblKeyInfo.Text = "B Key Pressed";
                this.BackColor = Color.LightBlue;
            }
            else if (e.KeyCode == Keys.R)
            {
                lblKeyInfo.Text = "R Key Pressed";
                this.BackColor = Color.Red;
            }
            else if (e.KeyCode == Keys.Y)
            {
                lblKeyInfo.Text = "Y Key Pressed";
                this.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.G)
            {
                lblKeyInfo.Text = "G Key Pressed";
                this.BackColor = Color.Green;
            }
            else
                lblKeyInfo.Text = "Irrelevent Key Pressed";
        }

        private void FormKeyboard_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                lblKeyInfo.Text = "Up Arrow Released";
            else if (e.KeyCode == Keys.Down)
                lblKeyInfo.Text = "Down Arrow Released";
            else if (e.KeyCode == Keys.Left)
                lblKeyInfo.Text = "Left Arrow Released";
            else if (e.KeyCode == Keys.Right)
                lblKeyInfo.Text = "Right Arrow Released";
            else if (e.KeyCode == Keys.B)
            {
                lblKeyInfo.Text = "B Key Released";
                this.BackColor = Form.DefaultBackColor;
            }
            else if (e.KeyCode == Keys.R)
            {
                lblKeyInfo.Text = "R Key Released";
                this.BackColor = Form.DefaultBackColor;
            }
            else if (e.KeyCode == Keys.Y)
            {
                lblKeyInfo.Text = "Y Key Released";
                this.BackColor = Form.DefaultBackColor;
            }
            else if (e.KeyCode == Keys.G)
            {
                lblKeyInfo.Text = "G Key Released";
                this.BackColor = Form.DefaultBackColor;
            }
            else
                lblKeyInfo.Text = "Irrelevent Key Released";
        }
    }
}
