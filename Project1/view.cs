using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class view : UserControl
    {
        public view()
        {

            InitializeComponent();
        }
        viewClass a = new viewClass();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            a.ID = txtID.Text;
            a.FullName = txtFullName.Text;
            a.Email = txtEmail.Text;
            a.PhoneNo = txtPhoneNo.Text;
            a.UserName = txtUserName.Text;
            a.Password = txtPassword.Text;

            bool Success = a.Insert(a);
            if (Success == true)
            {
                MessageBox.Show("Successfully Saved");

                clear();
            }
            else
            {
                MessageBox.Show("Failed to Save!");

            }
            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            a.AdminID = Convert.ToInt32(txtID.Text);
            bool Success = a.Delete(a);


            if (Success == true)
            {
                MessageBox.Show("Delete Successfully");


            }
            else
            {
                MessageBox.Show("Faileed to Delete,Try Again!");
            }
            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;
        }

        private void view_Load(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void clear()
        {
            txtID.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhoneNo.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtID.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            txtFullName.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            txtPhoneNo.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            txtUserName.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            a.AdminID = int.Parse(txtID.Text);
            a.ID = txtID.Text;
            a.FullName = txtFullName.Text;
            a.Email = txtEmail.Text;
            a.PhoneNo = txtPhoneNo.Text;
            a.UserName = txtUserName.Text;
            a.Password = txtPassword.Text;

            bool Success = a.Update(a); 
            if (Success == true)
            {
                MessageBox.Show("Successfully Edited");
                DataTable dt = a.Select();
                dataGridView1.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Edit!");

            }
            
        }
    }
}
