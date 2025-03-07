using LibreHub.Models;
using LIbreHubBackend.Models;

namespace LIbreHubBackend.Domain
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class BookDTO
    {

        public int Id { get; set; }


        public string Title { get; set; }


        public string Author { get; set; }


        public string Genre { get; set; }

        [Column("publication_year")]
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