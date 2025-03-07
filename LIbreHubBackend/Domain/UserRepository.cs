using Npgsql;

namespace LIbreHubBackend.Domain
{
    public class UserRepository
    {
        private readonly NpgsqlConnection _connection;

        public UserRepository(NpgsqlConnection connection)
        {
            _connection = connection;
        }
    }
}
