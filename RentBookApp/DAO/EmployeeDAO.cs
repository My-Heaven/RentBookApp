﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentBookApp.DAO
{
    public class EmployeeDAO
    {
        String cs = @"Data Source=TANDAT\SQLEXPRESS;Initial Catalog=RentBooksApp;Persist Security Info=True;User ID=sa;Password=dat123";
        public string CheckLogin(string Username, string Password)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select [fullname] from[dbo].[tblAccount] where[username] = @username and [password] = @password", con);
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


