using LibraryManagement.Core.Entities;
using LibraryManagement.Core.IService;
using LibraryManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryManagement.Controllers
{
    //[Authorize]
    [RoutePrefix("api/Book")]
    public class BookController : ApiController
    {
        private IBookService service;

        public BookController()
        {
            service = new BookService();
        }

        [HttpGet]
        [Route("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return service.GetBook();
        }

        [HttpGet]
        [Route("GetBook/{id}")]
        public Book GetBook(string id)
        {
            return service.GetBook(id);
        }
    }
}
