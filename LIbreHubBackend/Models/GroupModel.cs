using LIbreHubBackend.Domain;

namespace LIbreHubBackend.Models
{
    public class GroupModel
    {
        public int GroupID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public GroupDTO ToDTO() => new GroupDTO
        {
            Id = GroupID,
            Name = Name,
            Description = Description,
            Created_By = CreatedBy,
            Created_At = CreatedAt,
        };
    }
}
