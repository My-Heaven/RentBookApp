using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentBookApp.DAO
{
    public class EmployeeDAO
    {
        String cs = ConnectString.str;
        public string CheckLogin(string Username, string Password)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select [fullName] from tblEmployees where[userName] = @username and [password] = @password", con);
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        return sdr.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}


