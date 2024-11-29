using FinanceManager.Server.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<EachPurchaseEntity> EachPurchases { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }


    }
}
