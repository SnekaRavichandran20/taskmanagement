using System.Runtime.Serialization;

namespace TaskManagementAPI.Dtos
{
    [DataContract]
    public partial class TaskDto
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "due_date")]
        public DateTime? DueDate { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "user_id")]
        public Guid UserId { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "notes")]
        public List<NoteDto> Notes { get; set; }

        [DataMember(Name = "attachments")]
        public List<AttachmentDto> Attachments { get; set; }
    }
}