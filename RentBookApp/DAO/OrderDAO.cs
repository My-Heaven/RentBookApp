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
    public class OrderDAO
    {
        string cs = ConnectString.str;
        public bool createOrder(OrderDTO dto)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(cs);
            string sql = "insert into [dbo].[tblOrders](creater, Costomer, orderDate, returnDate, price, status) values (@creater,@Costomer,@orderDate,@returnDate,@price,@status)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@creater", dto.creater);
            cmd.Parameters.AddWithValue("@Costomer", dto.Costomer);
            cmd.Parameters.AddWithValue("@orderDate", dto.orderDate);
            cmd.Parameters.AddWithValue("@returnDate", dto.returnDate);
            cmd.Parameters.AddWithValue("@price", dto.price);
            cmd.Parameters.AddWithValue("@status", dto.status);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }
        public int getOrderID()
        {
            SqlConnection cn = new SqlConnection(cs);
            string SQL = "select top 1 [orderID] from [dbo].[tblOrders] order by [orderID] desc";
            SqlCommand cmd = new SqlCommand(SQL, cn);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (sdr.HasRows)
            {
                if (sdr.Read())
                {
                    return (int)sdr["orderID"];
                }
            }
            return -1;
        }
        public bool createOrderDetail(OrderDetailDTO dto)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(cs);
            string sql = "insert into [dbo].[tblOderDetail](orderID, bookID, price) values (@orderID,@bookID,@price)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@orderID", dto.orderID);
            cmd.Parameters.AddWithValue("@bookID", dto.bookID);
            cmd.Parameters.AddWithValue("@price", dto.price);
            cmd.Parameters.AddWithValue("@price", dto.price);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }
    }
}
