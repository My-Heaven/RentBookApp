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
    public class BookTypeDAO
    {
        public static string strConnection = ConnectString.str;
        public static List<BookTypeDTO> getBookTypes()
        {
            List<BookTypeDTO> list = null;
            SqlConnection cnn = new SqlConnection(strConnection);
            string sql = "select typeID, typeName from tblBookTypes";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string typeID = (string)reader["typeID"];
                    string typeName = (string)reader["typeName"];
                    BookTypeDTO type = new BookTypeDTO(typeID, typeName);
                    if (list == null)
                        list = new List<BookTypeDTO>();
                    list.Add(type);
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                reader.Close();
                cnn.Close();
            }
            return list;
        }
    }
}
