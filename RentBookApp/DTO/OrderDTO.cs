using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentBookApp.DTO
{
    public class OrderDTO
    {
        public int orderID { get; set; }
        public string creater { get; set; }
        public string Costomer { get; set; }
        public string orderDate { get; set; }
        public string returnDate { get; set; }
        public float price { get; set; }
        public bool status { get; set; }
    }
}
