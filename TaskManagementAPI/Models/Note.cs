using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents a note associated with a task in the task management system.
    /// </summary>
    [Table("Notes")]
    public class Note : BaseModel
    {
        /// <summary>
        /// Gets or sets the content of the note.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the task ID associated with the note.
        /// </summary>
        public Guid TaskId { get; set; }

        /// <summary>
        /// Gets or sets the task associated with the note.
        /// </summary>
        public Task Task { get; set; }

        /// <summary>
        /// Gets or sets the created by user ID associated with the note.
        /// </summary>
        public Guid CreatedBy { get; set; }
    }
}
