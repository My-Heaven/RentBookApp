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
        public bool addNewBook(BookDTO book)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(cs);
            string sql = "insert tblBooks(bookTitle, quantity, price, typeID, author, publishingYear, createDate, status) values(@bookTitle,@quantity,@price,@typeID,@author,@publishingYear,GETDATE(),@status)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@bookTitle", book.bookTitle);
            cmd.Parameters.AddWithValue("@quantity",book.quantity);
            cmd.Parameters.AddWithValue("@price",book.price);
            cmd.Parameters.AddWithValue("@typeID",book.typeID);
            cmd.Parameters.AddWithValue("@author",book.author);
            cmd.Parameters.AddWithValue("@publishingYear",book.publishingYear);
            cmd.Parameters.AddWithValue("@status",book.status);
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
        public bool updateBook(BookDTO book)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(cs);
            string sql = "update tblBooks " +
                "set bookTitle=@bookTitle,author=author,price=@price,publishingYear=@publishingYear,quantity=@quantity,typeID=@typeID " +
                "where bookID=@bookID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@bookTitle", book.bookTitle);
            cmd.Parameters.AddWithValue("@quantity", book.quantity);
            cmd.Parameters.AddWithValue("@price", book.price);
            cmd.Parameters.AddWithValue("@typeID", book.typeID);
            cmd.Parameters.AddWithValue("@author", book.author);
            cmd.Parameters.AddWithValue("@publishingYear", book.publishingYear);
            cmd.Parameters.AddWithValue("@bookID", book.bookID);
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
        public DataTable getBook(string bookTitle)
        {
            DataTable books = null;
            SqlConnection cnn = new SqlConnection(cs);
            string SQL = "select bookID, bookTitle, quantity, price, typeID, author, publishingYear, createDate from tblBooks where bookTitle like @bookTitle and status='true'";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@bookTitle", "%" + bookTitle + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            books = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                da.Fill(books);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return books;
        }
    }
}
