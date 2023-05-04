using Project1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class addTour : Form
    {
        public addTour()
        {
            InitializeComponent();
        }

        public static string Tname;
        public static string Description;
        public static string Costs;
        public static string  Duration;
        int pos = 0;

        public void Nextb()
        {
            pos = 0;
            editTour ed = new editTour();
            DataTable dt = t.Select();
            
        }

        tourClass t = new tourClass();
        public string ImageName = "no-image.jpg";
         string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.TourName = txtName.Text;
            t.Destination = cmbDestination.Text;
            t.Duration = txtDuration.Text;
            t.Accomodation = cmbAccomodation.Text;
            t.Transportation = cmbTransportation.Text;
            t.Costs = txtCosts.Text;
            t.Description = txtDescription.Text;
            t.ImageName = ImageName;

            bool success = t.Insert(t);

            if (success == true)
            {
                MessageBox.Show("New Tour Added Successfully.");

                Name = t.TourName;
                Description = t.Description;
                Costs = t.Costs;
                Duration = t.Duration;

                editTour ed = new editTour();
                DataTable dt = t.Select();
                ed.dtgvTour.DataSource = dt;

                clear();
            }
            else
            {
                MessageBox.Show("Failed to add,Try Again");
            }
        }

        private void txtTransportation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            cmbDestination.Text = "";
            txtDuration.Text = "";
            cmbAccomodation.Text = "";
            cmbTransportation.Text = "";
            txtCosts.Text = "";
            txtDescription.Text = "";
           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            t.TourID = int.Parse(txtID.Text);
            t.TourName = txtName.Text;
            t.Destination = cmbDestination.Text;
            t.Duration = txtDuration.Text;
            t.Accomodation = cmbAccomodation.Text;
            t.Transportation = cmbTransportation.Text;
            t.Costs = txtCosts.Text;
            t.Description = txtDescription.Text;
            t.ImageName = ImageName;

            bool success = t.Update(t);

            if (success == true)
            {
                MessageBox.Show("Updated Successfully.");

                editTour ed = new editTour();
                DataTable dt = t.Select();
                ed.dtgvTour.DataSource = dt;

                clear();
            }
            else
            {
                MessageBox.Show("Failed to Update,Try Again");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            t.TourID = int.Parse(txtID.Text);
            bool success = t.Delete(t);

            if (success == true)
            {
                MessageBox.Show("Delete Successfully.");

                editTour ed = new editTour();
                DataTable dt = t.Select();
                ed.dtgvTour.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete,Try Again");
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image File(*.jpg; *.jpeg; *.png; *.gifs;)|*.jpg; *.jpeg; *.png; *.gifs;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    pictureBox1.Image = new Bitmap(open.FileName);

                    string ext = Path.GetExtension(open.FileName);

                    Random random = new Random();
                    int RantInt = random.Next(0, 1000);

                    ImageName = "Tour_Photo" + RantInt + ext;

                    string sourcePath = open.FileName;
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    string destinationPath = paths + "\\image\\" + ImageName;

                    File.Copy(sourcePath, destinationPath);
                    MessageBox.Show("Image Upload Successfully");
                }
            }
        }

       
    }
}
