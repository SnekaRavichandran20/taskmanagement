using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents the base model with common properties.
    /// </summary>
    public abstract class BaseModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the created date and time.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the updated date and time.
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the boolean.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
