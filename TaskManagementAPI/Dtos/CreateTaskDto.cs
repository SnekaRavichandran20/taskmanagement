using System.Runtime.Serialization;

namespace TaskManagementAPI.Dtos
{
    [DataContract]
    public partial class CreateTaskDto
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "due_date")]
        public DateTime? DueDate { get; set; }

        [DataMember(Name = "user_id")]
        public Guid UserId { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}