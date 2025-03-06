using LibreHub.Models;

namespace LibreHub.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookModel> GetBooks();
    }
}
