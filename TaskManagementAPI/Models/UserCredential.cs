using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents the credentials of a user in the task management system.
    /// </summary>
    [Table("UserCredentials")]
    public class UserCredential : BaseModel
    {
        /// <summary>
        /// Gets or sets the user ID associated with the credentials.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the user associated with the credentials.
        /// </summary>
        public User User { get; set; }
    }
}
