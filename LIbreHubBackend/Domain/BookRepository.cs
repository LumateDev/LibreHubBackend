using Dapper;
using Npgsql;

namespace LIbreHubBackend.Domain
{
    /// <summary>
    /// Репозиторий для работы с PostgreSQL
    /// </summary>
    public class BookRepository
    {
        private readonly NpgsqlConnection _connection;
        public BookRepository(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<BookDTO>> GetBooksAsync()
        {
            const string sql = @"
            SELECT 
                id,
                title, 
                author, 
                genre, 
                publication_year,
                cover 
            FROM books";

            return await _connection.QueryAsync<BookDTO>(sql);
        }
    }
}