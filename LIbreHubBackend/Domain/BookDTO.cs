using LibreHub.Models;
using LIbreHubBackend.Models;

namespace LIbreHubBackend.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// DTO Нужен чтобы связать запись из БД с объектом ЯП C#
    /// </summary>
    public class BookDTO
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        [Column("publication_year")] // Т.к daper не может явно привести PublicationYear к snake_case
        public int PublicationYear { get; set; }

        public byte[] Cover { get; set; }

        public BookModel ToModel() => new BookModel
        {
            BookID = Id,
            Title = Title,
            Author = Author,
            Genre = Genre,
            PublicationYear = PublicationYear,
            Cover = Cover
        };
    }
}