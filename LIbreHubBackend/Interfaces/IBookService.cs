using LibreHub.Models;
using LIbreHubBackend.Models;

namespace LIbreHubBackend.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookModel>> GetBooksAsync();


    }
}
