using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentBookApp.DTO
{
    public class BookTypeDTO
    {
        public string typeID { get; set; }
        public string typeName { get; set; }

        public BookTypeDTO(string typeID, string typeName)
        {
            this.typeID = typeID;
            this.typeName = typeName;
        }
    }
}
