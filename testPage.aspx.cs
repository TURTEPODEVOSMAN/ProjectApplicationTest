using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLinj
{
    public partial class testPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // MSSQL veya MySQL için seçim yapılarak tesst yapılacak
            // true MSSQL
            bool useMSSQL = true;

            if (useMSSQL)
            {
                MSSQLLogin(username, password);
            }
            else
            {
                MySQLLogin(username, password);
            }
        }

        private void MSSQLLogin(string username, string password)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MSSQLConnection"].ConnectionString;
            string query = "SELECT COUNT(*) FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                lblMessage.Text = count > 0 ? "Giriş başarılı!" : "Giriş başarısız!";
            }
        }

        private void MySQLLogin(string username, string password)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            string query = "SELECT COUNT(*) FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblMessage.Text = count > 0 ? "Giriş başarılı!" : "Giriş başarısız!";
            }
        }

        ///* güvenli kod bloğu */
        //string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
        //using (SqlConnection conn = new SqlConnection(connectionString))
        //{
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@Username", username);
        //    cmd.Parameters.AddWithValue("@Password", password);
        //    conn.Open();
        //    int count = (int)cmd.ExecuteScalar();
        //    lblMessage.Text = count > 0 ? "Giriş başarılı!" : "Giriş başarısız!";
        //}

    }
}