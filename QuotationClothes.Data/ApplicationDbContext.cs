using Microsoft.EntityFrameworkCore;
using QuotationClothes.Entity;

namespace QuotationClothes.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-02JGB41;Database=QuotationClothesDB;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        public DbSet<Quotation> Quotations { get; set; } 
    }
}