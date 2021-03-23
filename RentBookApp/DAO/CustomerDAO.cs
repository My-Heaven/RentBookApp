using RentBookApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentBookApp.DAO
{
    public class CustomerDAO
    {
        String cs = @"Data Source=TANDAT\SQLEXPRESS;Initial Catalog=RentBooksApp;Persist Security Info=True;User ID=sa;Password=dat123";
        public bool CreateCustomer(CustomerDTO dto)
        {

            SqlConnection cnn = new SqlConnection(cs);
            string SQL = "insert [dbo].[tblCostomers]([Phone],[fullName],[Address]) values(@Phone,@Fullname,@Address)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@Name", dto.Phone);
            cmd.Parameters.AddWithValue("@FullName", dto.Fullname);
            cmd.Parameters.AddWithValue("@Address", dto.Address);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            if (count > 0) return true;
            return false;
        }
        public string checkCustomer(string Phone)
        {
            SqlConnection cn = new SqlConnection(cs);
            string SQL = "select [fullName] from[dbo].[tblCostomers] where[Phone] = @phone ";
            SqlCommand cmd = new SqlCommand(SQL, cn);
            cmd.Parameters.AddWithValue("@phone",Phone);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (sdr.HasRows)
            {
                if (sdr.Read())
                {
                    return sdr.GetString(0);
                }
            }
            return null;
        }

    }
}
