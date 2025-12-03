using LocadoraLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace LocadoraLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }

        public DbSet<LoanModel> Loans { get; set; }

    }
}
