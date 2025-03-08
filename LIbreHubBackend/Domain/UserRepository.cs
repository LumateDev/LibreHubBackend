using Dapper;
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

        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            const string sql = @"
            SELECT
                id,
                name,
                email,
                password_hash
            FROM users";

            return await _connection.QueryAsync<UserDTO>(sql);
        }
    }
}
