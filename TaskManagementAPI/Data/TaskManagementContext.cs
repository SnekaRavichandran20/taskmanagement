using Microsoft.EntityFrameworkCore;
using TaskManagementAPI.Models;

namespace TaskManagementSystem.Data
{
    /// <summary>
    /// Represents the database context for the Task Management System.
    /// </summary>
    public class RepositoryContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryContext"/> class.
        /// </summary>
        /// <param name="options">The options to configure the context.</param>
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options) { }

        /// <summary>
        /// Gets or sets the DbSet for refterm.
        /// </summary>
        public DbSet<RefTerm> RefTerms { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for project.
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for user.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for userCredential.
        /// </summary>
        public DbSet<UserCredential> UserCredentials { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for projectUserMapping.
        /// </summary>
        public DbSet<ProjectUserMapping> ProjectUserMappings { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for tasks.
        /// </summary>
        public DbSet<TaskManagementAPI.Models.Task> Tasks { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for note.
        /// </summary>
        public DbSet<Note> Notes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for attachment.
        /// </summary>
        public DbSet<Attachment> Attachments { get; set; }


         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskManagementAPI.Models.Task>()
                .HasMany(t => t.Notes)
                .WithOne(n => n.Task)
                .HasForeignKey(n => n.TaskId);
    
            modelBuilder.Entity<TaskManagementAPI.Models.Task>()
                .HasMany(t => t.Attachments)
                .WithOne(a => a.Task)
                .HasForeignKey(a => a.TaskId);
        }

        public override int SaveChanges()
        {
            var now = DateTime.UtcNow;
        
            foreach (var entry in ChangeTracker.Entries<BaseModel>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = now;
                }
            }
        
            return base.SaveChanges();
        }

    }
}
