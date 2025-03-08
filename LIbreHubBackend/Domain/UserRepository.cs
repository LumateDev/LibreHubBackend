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

        public async Task<UserDTO> AddUserAsync(UserDTO userDto)
        {
            const string sql = @"
            INSERT INTO users (name, email, password_hash)
            VALUES (@Name, @Email, @Password_Hash)
            RETURNING *";

            return await _connection.QuerySingleAsync<UserDTO>(sql, userDto);
        }
    }
}
