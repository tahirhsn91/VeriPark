using LibraryManagement.Core.Entities;
using LibraryManagement.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository
{
    public class BookRepository : IBookRepository
    {
        DBContext dbContext;

        public BookRepository()
        {
            dbContext = new DBContext();
        }

        public List<Book> GetBook()
        {
            return dbContext.Book.ToList();
        }

        public Book GetBook(string ID)
        {
            return dbContext.Book.FirstOrDefault(x => x.BookId == ID);
        }

        public void AddBook(Book book)
        {
            book.BookId = Guid.NewGuid().ToString();

            dbContext.Book.Add(book);
            dbContext.SaveChanges();
        }

        public void DeleteAllBook()
        {
            string sql = @"IF (EXISTS (SELECT * 
                                             FROM INFORMATION_SCHEMA.TABLES 
                                             WHERE TABLE_NAME = 'Books'))
                            BEGIN
                                DELETE FROM [Books]
                            END";
            dbContext.Database.ExecuteSqlCommand(sql);
        }
    }
}
