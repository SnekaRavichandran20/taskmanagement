using System.Runtime.Serialization;

namespace TaskManagementAPI.Dtos
{
    [DataContract]
    public partial class NoteDto
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "content")]
        public string Content { get; set; }

        [DataMember(Name = "created_date")]
        public DateTime CreatedDate { get; set; }

        [DataMember(Name = "created_by")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "is_edited")]
        public bool IsEdited { get; set; }
    }
}