using System.Runtime.Serialization;

namespace TaskManagementAPI.Dtos
{
    [DataContract]
    public partial class AttachmentDto
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "file_name")]
        public string FileName { get; set; }

        [DataMember(Name = "created_date")]
        public DateTime CreatedDate { get; set; }
    }
}



