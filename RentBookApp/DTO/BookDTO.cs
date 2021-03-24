using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentBookApp.DTO
{
    public class BookDTO
    {
        public int bookID { get;set; }
        public string bookTitle { get; set; }
        public int  quantity { get; set; }
        public float price { get; set; }
        public int typeID { get; set; }
        public string author { get; set; }
        public int publishingYear { get; set; }
        public string  createDate { get; set; }
        public bool status { get; set; }

        public BookDTO(string bookTitle, int quantity, float price, int typeID, string author, int publishingYear, string createDate, bool status)
        {
            this.bookTitle = bookTitle;
            this.quantity = quantity;
            this.price = price;
            this.typeID = typeID;
            this.author = author;
            this.publishingYear = publishingYear;
            this.createDate = createDate;
            this.status = status;
        }
    }
}
