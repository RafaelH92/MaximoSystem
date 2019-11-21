using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaximoSystem
{
    public partial class frmLogin : Form
    {
        Point point;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Close();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                point.X = this.Left - MousePosition.X;
                point.Y = this.Top - MousePosition.Y;
            }
            
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {

            if (MouseButtons == MouseButtons.Left)
            {
                this.Left = point.X + MousePosition.X;
                this.Top = point.Y + MousePosition.Y;
            }
           
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            
            
        }
    }
}
