using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents a user in the task management system.
    /// </summary>
    [Table("Users")]
    public class User : BaseModel
    {
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the role of the user (Employee, Manager, Admin).
        /// </summary>
        public Guid Role { get; set; }
    }
}
