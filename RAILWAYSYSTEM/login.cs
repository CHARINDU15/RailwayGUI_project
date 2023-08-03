using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RAILWAYSYSTEM
{
    public partial class FRM_LOGIN : Form
    {
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.BackColor = Color.White;
            panel_username.BackColor= Color.White;
            txt_password.BackColor= SystemColors.Control;
            panel_password.BackColor = SystemColors.Control;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.BackColor=Color.White;
            panel_password.BackColor = Color.White;
            txt_username.BackColor = SystemColors.Control;
            panel_username.BackColor = SystemColors.Control;

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar= true;
        }
    }
}
