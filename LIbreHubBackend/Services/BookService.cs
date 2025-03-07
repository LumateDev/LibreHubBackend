using LibreHub.Models;
using LIbreHubBackend.Domain;
using LIbreHubBackend.Interfaces;
using LIbreHubBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace LibreHub.Services
{
    public class BookService : IBookService
    {
        private readonly ILogger _logger;
        private readonly BookRepository _bookRepository;

        public BookService(BookRepository bookRepository, ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("BookService");
            _bookRepository = bookRepository;
        }


        public async Task<IEnumerable<BookModel>> GetBooksAsync()
        {
            try
            {
                var bookDtos = await _bookRepository.GetBooksAsync();
                return bookDtos.Select(dto => dto.ToModel());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting books");
                return Enumerable.Empty<BookModel>();
            }
        }



    }

}
