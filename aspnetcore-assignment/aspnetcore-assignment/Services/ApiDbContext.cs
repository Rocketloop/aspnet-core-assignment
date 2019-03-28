using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using aspnetcore_assignment.Models;

namespace aspnetcore_assignment.Services {

    /// <summary>
    /// Mockup db context.
    /// </summary>
    public class ApiDbContext :DbContext {
    
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

#pragma warning disable 1591
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Board> Bords { get; set; }
#pragma warning restore 1591


        /// <summary>
        /// Ons the model creating.
        /// </summary>
        /// <param name="modelBuilder">Model builder.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Todo>().HasIndex(t => t.Done);

            base.OnModelCreating(modelBuilder);
        }
    }
}
