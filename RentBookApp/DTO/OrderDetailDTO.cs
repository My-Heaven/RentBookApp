using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentBookApp.DTO
{
    public class OrderDetailDTO
    {
        public int detailID { get; set; }
        public int orderID { get; set; }
        public int bookID { get; set; }
        public float price { get; set; }
    }
}
