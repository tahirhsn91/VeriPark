using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Core.Entities
{
    public class Book
    {
        public string BookId { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public string ISBN { get; set; }

        public string Picture { get; set; }

        public string Price { get; set; }
    }
}
