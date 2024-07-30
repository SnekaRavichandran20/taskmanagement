using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents a task in the task management system.
    /// </summary>
    [Table("Tasks")]
    public class Task : BaseModel
    {
        /// <summary>
        /// Gets or sets the title of the task.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the due date of the task.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the status of the task.
        /// </summary>
        public Guid Status { get; set; }

        /// <summary>
        /// Gets or sets the project ID associated with the task.
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the user ID associated with the task.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the user associated with the task.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the collection of notes associated with the task.
        /// </summary>
        public ICollection<Note> Notes { get; set; }

        /// <summary>
        /// Gets or sets the collection of attachments associated with the task.
        /// </summary>
        public ICollection<Attachment> Attachments { get; set; }
    }
}
