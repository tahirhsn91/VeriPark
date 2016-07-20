using LibraryManagement.Core.Entities;
using LibraryManagement.Core.IRepository;
using LibraryManagement.Core.IService;
using LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service
{
    public class BookService : IBookService
    {
        private IBookRepository repository;

        public BookService()
        {
            repository = new BookRepository();
        }

        public List<Book> GetBook()
        {
            return repository.GetBook();
        }

        public Book GetBook(string ID)
        {
            return repository.GetBook(ID);
        }

        public void AddBook(Book book)
        {
            repository.AddBook(book);
        }

        public void DeleteAllBook()
        {
            repository.DeleteAllBook();
        }
    }
}
