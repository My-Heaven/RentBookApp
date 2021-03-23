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
        String cs = @"Data Source=TANDAT\SQLEXPRESS;Initial Catalog=RentBooksApp;Persist Security Info=True;User ID=sa;Password=hanhvu0978";
        public bool CreateCustomer(CustomerDTO dto)
        {

            SqlConnection cnn = new SqlConnection(cs);
            string SQL = "insert [dbo].[tblBooks]([BookName],[BookPrice]) values(@Phone,@Price)";
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

    }
}
