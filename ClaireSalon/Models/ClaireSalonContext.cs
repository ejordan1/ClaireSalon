using Microsoft.EntityFrameworkCore;

namespace ClaireSalon.Models
{
  public class ClaireSalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }
    
    public ClaireSalonContext(DbContextOptions options) : base(options) { }
  }
}