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
    public partial class index : Form
    {

        int panelWidth;
        bool isCollapsed;
        public index()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
        }
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

          private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 61)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }
        private void moveslide_panel(Control btn)
        {
            panel5.Top = btn.Top;
            panel5.Height = btn.Height;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            hotel openForm = new hotel();
            openForm.Show();
            Visible = false;
        }

       

        private void btnCar_Click(object sender, EventArgs e)
        {
            car openForm = new car();
            openForm.Show();
            Visible = false;
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            tour openForm = new tour();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login openForm = new Login();
            openForm.Show();
            Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveslide_panel(button3);
            caruc car = new caruc();
            addControlsToPanel(car);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveslide_panel(button2);
            cruises cr = new cruises();
            addControlsToPanel(cr);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            moveslide_panel(button1);
            touruc tc = new touruc();
            addControlsToPanel(tc);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
