using LibreHub.Interfaces;
using LibreHub.Models;
using LibreHub.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibreHub.Controllers
{

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
        public async Task<IActionResult> GetBooks()
        {
            return Ok(_bookService.GetBooks());
        }



        [HttpGet("/aboba")]
        public async Task<IActionResult> Aboba()
        {
            string a = "fkldsjfl";
            return Ok(a);
        }
    }
}
