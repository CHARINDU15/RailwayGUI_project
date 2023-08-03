using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RAILWAYSYSTEM
{
    public partial class frm_loading : Form
    {
        [DllImport("Gdi32.dll", EntryPoint ="CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllips,
            int nHeightEllips

        );

        public frm_loading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar_loading1.Value = 0;
        }

        private void panel2_click (object sender, PaintEventArgs e)
        {

        }

        private void frm_loading_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar_loading1.Value += 1;
            circularProgressBar_loading1.Text = circularProgressBar_loading1.Value.ToString() +"%";

            if (circularProgressBar_loading1.Value == 100)
            {
                timer1.Enabled = false;
                FRM_LOGIN fRM_LOGIN = new FRM_LOGIN();
                fRM_LOGIN.Show();
                this.Hide();
            }
        }
    }
}
