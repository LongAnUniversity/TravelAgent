using Core.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Models.EF
{
    public class TravelAgentContext : DbContext
    {
        public TravelAgentContext(DbContextOptions<TravelAgentContext> options) : base(options) { }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
