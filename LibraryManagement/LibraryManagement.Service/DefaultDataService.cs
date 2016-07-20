using LibraryManagement.Core.Entities;
using LibraryManagement.Core.IRepository;
using LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service
{
    public class DefaultDataService
    {
        IUserRepository userRepository;
        IBookRepository bookRepository;

        public DefaultDataService()
        {
            userRepository = new UserRepository();
            bookRepository = new BookRepository();
        }

        public void FillDefaultData()
        {
            #region Add Users
            userRepository.DeleteAllUser();

            User user1 = new User();
            user1.Name = "tahir";
            user1.UserName = "tahir";
            user1.Password = "tahir";
            user1.UserId = Guid.NewGuid().ToString();
            userRepository.AddUser(user1);


            User user2 = new User();
            user2.Name = "admin";
            user2.UserName = "admin";
            user2.Password = "admin";
            userRepository.AddUser(user2);

            User user3 = new User();
            user3.Name = "user1";
            user3.UserName = "user1";
            user3.Password = "user1";
            userRepository.AddUser(user3);
            #endregion

            #region Book
            bookRepository.DeleteAllBook();

            Book book1 = new Book();
            book1.Title = "Book 1";
            book1.Year = "2013";
            book1.ISBN = "12233333333332222";
            book1.Picture = "";
            book1.Price = "123";
            bookRepository.AddBook(book1);

            Book book2 = new Book();
            book2.Title = "Book 2";
            book2.Year = "2014";
            book2.ISBN = "33333222222111111";
            book2.Picture = "";
            book2.Price = "321";
            bookRepository.AddBook(book2);


            Book book3 = new Book();
            book3.Title = "Book 3";
            book3.Year = "2015";
            book3.ISBN = "99999999988888877";
            book3.Picture = "";
            book3.Price = "998";
            bookRepository.AddBook(book3);


            #endregion
        }
    }
}
