using LibreHub.Interfaces;
using LibreHub.Models;
using System.Collections;

namespace LibreHub.Services
{
    public class BookService : IBookService
    {
        public IEnumerable<BookModel> GetBooks()
        {
            return new List<BookModel>
        {
            new BookModel { Name = "aboba", Title = "Book 1", Description = "Description of Book 1" },
            new BookModel { Name = "aboba", Title = "Book 2", Description = "Description of Book 2" },
            new BookModel { Name = "aboba", Title = "Book 3", Description = "Description of Book 3" }
        };
        }
    }


}
