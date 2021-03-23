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
                    int bookID = (int)sdr["bookID"];
                    string bookTitle = sdr["bookTitle"].ToString();
                    int quantity = (int)sdr["quantity"];
                    float price = float.Parse(sdr["price"].ToString());
                    int typeID = (int)sdr["typeID"];
                    string author = sdr["author"].ToString();
                    int publishingYear = (int)sdr["publishingYear"];
                    string createDate = sdr["createDate"].ToString();
                    bool status = (bool)sdr["status"];

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
