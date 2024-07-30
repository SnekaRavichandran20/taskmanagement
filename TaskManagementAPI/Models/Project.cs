using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents a Project in the task management system.
    /// </summary>
    [Table("Project")]
    public class Project : BaseModel
    {
        /// <summary>
        /// Gets or sets the name of the Project.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the Project.
        /// </summary>
        public string Description { get; set; }
    }
}
