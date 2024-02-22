using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ExampleName.Models
{
  public class ProjectNameContext : DbContext
  {
    public DbSet<T> Name { get; set; }

    public ProjectNameContext(DbContextOptions options) : base(options) { }
  }
}