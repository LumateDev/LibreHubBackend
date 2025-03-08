using LIbreHubBackend.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIbreHubBackend.Domain
{
    public class GroupDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Column("created_by")]
        public int Created_By { get; set; }

        [Column("created_at")]
        public DateTime Created_At { get; set; }

        public GroupModel ToModel() => new GroupModel
        {
            GroupID = Id,
            Name = Name,
            Description = Description,
            CreatedBy = Created_By,
            CreatedAt = Created_At,
        };
    }
}
