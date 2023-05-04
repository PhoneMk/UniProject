using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Class
{
    class loginClass
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstg"].ConnectionString;

        public bool loginCheck()
        {
            bool isSuccess = false;

            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT * FROM tblUsers WHERE UserName=@UserName AND Password=@Password";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
