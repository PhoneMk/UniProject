using Project1.Class;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        loginClass l = new loginClass();

        public static string loggedInUser;
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            index ind = new index();
            ind.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.UserName = txtName.Text;
            l.Password = txtPassword.Text;

            bool isSuccess = l.loginCheck();
            if (isSuccess == true)
            {
                MessageBox.Show("Login Successful");

                loggedInUser = l.UserName;
                admin ad = new admin();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Name or Password is Incorrect! Try Again.");

            }
           
        }

    
    }
}
