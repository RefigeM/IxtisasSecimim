using Ixtisas_Secimim.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Ixtisas_Secimim.DAL
{
    public class SpecializationDbContext : DbContext
    {
        public SpecializationDbContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           

            // Capture entity deyil → ignore elə
            modelBuilder.Ignore<System.Text.RegularExpressions.Capture>();
        }
    }
}
