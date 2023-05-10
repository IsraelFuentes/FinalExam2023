using Microsoft.EntityFrameworkCore;

namespace Mid_Term.Models
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {
        }
        // DbSet creates the Table needed
        // DbSet needes an Using statement from the model the table is being created from
        public DbSet<Products> Produtcs { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
