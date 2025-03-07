using LIbreHubBackend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LIbreHubBackend.Controllers
{
    /// <summary>
    /// BookContoller обрабатывает запросы пользователя. API
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("/getBooks")]
        public async Task<IActionResult> GetBooksAsync()
        {

            var books = await _bookService.GetBooksAsync();
            return Ok(books);
        }

    }
}
