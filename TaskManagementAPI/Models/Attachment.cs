using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents an attachment associated with a task in the task management system.
    /// </summary>
    [Table("Attachments")]
    public class Attachment : BaseModel
    {
        /// <summary>
        /// Gets or sets the file path of the attachment.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file name of the attachment.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the task ID associated with the attachment.
        /// </summary>
        public Guid TaskId { get; set; }

        /// <summary>
        /// Gets or sets the task associated with the attachment.
        /// </summary>
        public Task Task { get; set; }
    }
}
