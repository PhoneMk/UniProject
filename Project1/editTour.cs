using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project1.Class;

namespace Project1
{
    public partial class editTour : UserControl
    {
        public editTour()
        {
            InitializeComponent();
        }

        tourClass t = new tourClass();

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewTour_Click(object sender, EventArgs e)
        {
            using (addTour ad = new addTour())
            {
                ad.ShowDialog();                
            }
        }

        private void editTour_Load(object sender, EventArgs e)
        {
            DataTable dt = t.Select();
            dtgvTour.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgvTour_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dtgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgvTour.Rows[index];

            addTour ad = new addTour();
            ad.Show();

            ad.txtID.Text = dtgvTour.Rows[index].Cells[0].Value.ToString();
            ad.txtName.Text = dtgvTour.Rows[index].Cells[1].Value.ToString();
            ad.cmbDestination.Text = dtgvTour.Rows[index].Cells[2].Value.ToString();
            ad.txtDuration.Text = dtgvTour.Rows[index].Cells[3].Value.ToString();
            ad.cmbAccomodation.Text = dtgvTour.Rows[index].Cells[4].Value.ToString();
            ad.cmbTransportation.Text = dtgvTour.Rows[index].Cells[5].Value.ToString();
            ad.txtCosts.Text = dtgvTour.Rows[index].Cells[6].Value.ToString();
            ad.txtDescription.Text = dtgvTour.Rows[index].Cells[7].Value.ToString();
            ad.ImageName = dtgvTour.Rows[index].Cells[8].Value.ToString();

            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                string imagePath = paths + "\\image\\" + ad.ImageName;
                ad.pictureBox1.Image = new Bitmap(imagePath);
          

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbltourBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dtgvTour_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dtgvTour.Rows[index];

            touruc tc = new touruc();
            addTour ad = new addTour();
            ad.Show();

            ad.txtID.Text = dtgvTour.Rows[index].Cells[0].Value.ToString();
            ad.txtName.Text = dtgvTour.Rows[index].Cells[1].Value.ToString();
            ad.cmbDestination.Text = dtgvTour.Rows[index].Cells[2].Value.ToString();
            ad.txtDuration.Text = dtgvTour.Rows[index].Cells[3].Value.ToString();
            ad.cmbAccomodation.Text = dtgvTour.Rows[index].Cells[4].Value.ToString();
            ad.cmbTransportation.Text = dtgvTour.Rows[index].Cells[5].Value.ToString();
            ad.txtCosts.Text = dtgvTour.Rows[index].Cells[6].Value.ToString();
            ad.txtDescription.Text = dtgvTour.Rows[index].Cells[7].Value.ToString();

            ad.txtID.Text = tc.lblName.Text;
            



        }
    }
}
