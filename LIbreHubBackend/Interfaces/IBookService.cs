using LibreHub.Models;
using LIbreHubBackend.Models;

namespace LIbreHubBackend.Interfaces
{
    /// <summary>
    /// Требования к методам сервисам
    /// </summary>
    public interface IBookService
    {
        Task<IEnumerable<BookModel>> GetBooksAsync();


    }
}
