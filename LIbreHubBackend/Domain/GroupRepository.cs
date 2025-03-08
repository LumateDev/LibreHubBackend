using Dapper;
using Npgsql;

namespace LIbreHubBackend.Domain
{
    public class GroupRepository
    {
        private readonly NpgsqlConnection _connection;

        public GroupRepository(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<GroupDTO>> GetGroupsAsync()
        {
            const string sql = @"
            SELECT
                id,
                name,
                description,
                created_by,
                created_at
            FROM groups";

            return await _connection.QueryAsync<GroupDTO>(sql);
        }
    }
}
