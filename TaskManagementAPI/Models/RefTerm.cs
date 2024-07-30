using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementAPI.Models
{
    /// <summary>
    /// Represents a RefTerm in the task management system.
    /// </summary>
    [Table("RefTerm")]
    public class RefTerm : BaseModel
    {
        /// <summary>
        /// Gets or sets the name of the Refterm.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the Refterm.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Set of the Refterm.
        /// </summary>
        public string Set { get; set; }

        /// <summary>
        /// Gets or sets the Sortorder of the Refterm.
        /// </summary>
        public int Sortorder { get; set; }
    }
}
