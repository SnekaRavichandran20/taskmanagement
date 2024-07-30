using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents a ProjectUserMapping in the task management system.
    /// </summary>
    [Table("ProjectUserMapping")]
    public class ProjectUserMapping : BaseModel
    {
        /// <summary>
        /// Gets or sets the Id of the Project.
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the User.
        /// </summary>
        public Guid UserId { get; set; }
    }
}
