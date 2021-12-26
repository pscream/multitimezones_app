using Microsoft.EntityFrameworkCore;

using WebApi.Models.Database;
using WebApi.DataContext.Configs;

namespace WebApi.DataContext
{

    public class ProjectContext : DbContext
    {

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }

        public DbSet<Ticket> Tickets { get; set; }

    }

}