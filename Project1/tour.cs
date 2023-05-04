using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class tour : Form
    {
        public tour()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            index openForm = new index();
            openForm.Show();
            Visible = false;
        }

        private void tour_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
