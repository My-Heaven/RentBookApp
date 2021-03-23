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
    public class BooksDAO
    {
        string cs = ConnectString.str;
        public BookDTO findBook(string BookID)
        {
            SqlConnection cn = new SqlConnection(cs);
            string SQL = "select bookID,bookTitle, quantity, price, typeID, author, publishingYear, createDate, status from [dbo].[tblBooks] where [bookID] = @bookID";
            SqlCommand cmd = new SqlCommand(SQL, cn);
            cmd.Parameters.AddWithValue("@bookID", BookID);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (sdr.HasRows)
            {
                if (sdr.Read())
                {
                    int bookID = sdr.GetInt32(0);
                    string bookTitle = sdr.GetString(1);
                    int quantity = sdr.GetInt32(2);
                    float price = sdr.GetFloat(3);
                    int typeID = sdr.GetInt32(4);
                    string author = sdr.GetString(5);
                    int publishingYear = sdr.GetInt32(6);
                    string createDate = sdr.GetString(7);
                    bool status = sdr.GetBoolean(8);

                    BookDTO dto = new BookDTO
                    {
                        bookID = bookID,
                        bookTitle = bookTitle,
                        quantity = quantity,
                        price = price,
                        typeID = typeID,
                        author = author,
                        publishingYear = publishingYear,
                        createDate = createDate,
                        status = status
                    };
                    return dto;

                }
            }
            return null;
        }
    }
}
