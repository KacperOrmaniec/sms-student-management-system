using Microsoft.EntityFrameworkCore;
using studentManagementSystem.Data.Types;

namespace studentManagementSystem.Data.Database;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId); 
        });
    }
}