using LibraryManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Core.IService
{
    public interface IBookService
    {
        List<Book> GetBook();

        Book GetBook(string ID);

        void AddBook(Book book);

        void DeleteAllBook();
    }
}
