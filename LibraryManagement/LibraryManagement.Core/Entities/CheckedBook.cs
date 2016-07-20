using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Core.Entities
{
    public class CheckedBook
    {
        public string CheckedBookID { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string NationalID { get; set; }

        public DateTime CheckOutDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public bool IsReturn { get; set; }

        Book Book { get; set; }
    }
}
