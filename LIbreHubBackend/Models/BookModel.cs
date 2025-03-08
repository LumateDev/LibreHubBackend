using LIbreHubBackend.Domain;

namespace LIbreHubBackend.Models
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public byte[] Cover { get; set; }


        //public string CoverBase64 => Cover != null ? Convert.ToBase64String(Cover) : null;

        public BookDTO ToDTO() => new BookDTO
        {
            Id = BookID,
            Title = Title,
            Author = Author,
            Genre = Genre,
            Publication_Year = PublicationYear,
            Cover = Cover
        };
    }
}