using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mathee_Stephanus_PRG282_Exam
{
    internal class DataHandler
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-8GCK8IN\SQLEXPRESS; Initial Catalog = MetaPlatformDB; Integrated Security = True");
        SqlCommand cmd;
        public BindingSource bs = new BindingSource();

        public void GetData(string email)
        {
            SqlDataReader reader;
            if(email != "")
            {
                try
                {
                    cmd = new SqlCommand("GetUsers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        bs.DataSource= reader;
                    }
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
        }
        public void InsertData(User user)
        {
            try
            {
                cmd = new SqlCommand("InsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", user.FName);
                cmd.Parameters.AddWithValue("@Lastname", user.LName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Birthday", user.Birthdate);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has successfuly been added");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void DeleteUser(string email)
        {
            try
            {
                cmd = new SqlCommand("DeleteUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has successfuly been removed");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
