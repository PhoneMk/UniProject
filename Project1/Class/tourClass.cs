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
    class tourClass
    {
        public int TourID { get; set; }
        public string TourName { get; set; }
        public string Destination { get; set; }
        public string Duration { get; set; }
        public string Accomodation { get; set; }
        public string Transportation { get; set; }
        public string Costs { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstg"].ConnectionString;
        internal object dtgvTour;
         
        
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_tour";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                conn.Open();
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert(tourClass t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO tbl_tour(TourName, Destination, Duration, Accomodation, Transportation, Costs, Description, ImageName) VALUES (@TourName, @Destination, @Duration, @Accomodation, @Transportation, @Costs, @Description, @ImageName)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TourName", t.TourName);
                cmd.Parameters.AddWithValue("@Destination", t.Destination);
                cmd.Parameters.AddWithValue("@Duration", t.Duration);
                cmd.Parameters.AddWithValue("@Accomodation", t.Accomodation);
                cmd.Parameters.AddWithValue("@Transportation", t.Transportation);
                cmd.Parameters.AddWithValue("@Costs", t.Costs);
                cmd.Parameters.AddWithValue("@Description", t.Description);
                cmd.Parameters.AddWithValue("@ImageName", t.ImageName);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Update(tourClass t)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE tbl_tour SET TourName=@TourName, Duration=@Duration, Destination=@Destination, Accomodation=@Accomodation, Transportation=@Transportation, Costs=@Costs, Description=@Description, ImageName=@ImageName WHERE TourID=@TourID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TourName", t.TourName);
                cmd.Parameters.AddWithValue("@Destination", t.Destination);
                cmd.Parameters.AddWithValue("@Duration", t.Duration);
                cmd.Parameters.AddWithValue("@Accomodation", t.Accomodation);
                cmd.Parameters.AddWithValue("@Transportation", t.Transportation);
                cmd.Parameters.AddWithValue("@Costs", t.Costs);
                cmd.Parameters.AddWithValue("@Description", t.Description);
                cmd.Parameters.AddWithValue("@ImageName", t.ImageName);
                cmd.Parameters.AddWithValue("@TourID", t.TourID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Delete(tourClass t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM tbl_tour WHERE TourID=@TourID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TourID", t.TourID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
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
