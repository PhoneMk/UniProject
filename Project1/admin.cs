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
    public partial class admin : Form
    {
        int panelWidth;
        bool isCollapsed;
        public admin()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 15;
                if(panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 13;
                if(panelLeft.Width <= 61)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);

        }
        private void moveslide_panel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveslide_panel(btnHome);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            moveslide_panel(btnEdit);
            editTour et = new editTour();
            addControlsToPanel(et);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            moveslide_panel(btnExpense);
            Income ic = new Income();
            addControlsToPanel(ic);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            moveslide_panel(btnView);
            view vi = new view();
            addControlsToPanel(vi);
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            lblUser.Text = Login.loggedInUser; 
        }

        private void admin_Load(object sender, EventArgs e)
        {
        
        }
    }

}
;