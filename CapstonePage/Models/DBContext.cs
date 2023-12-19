using Microsoft.EntityFrameworkCore;

namespace Capstone.Models
{
  public class CapstoneContext : DbContext
  {
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceEmployeeEntity> ServiceEmployeeEntities { get; set; }

    public CapstoneContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServiceEmployeeEntity>()
            .HasKey(ps => new { ps.EmployeeId, ps.ServiceId });
    }
  }
}