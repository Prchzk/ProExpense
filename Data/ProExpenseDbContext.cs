using Microsoft.EntityFrameworkCore;
using ProExpense.Models;

namespace ProExpense.Data
{
    public class ProExpenseDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ProExpenseDbContext(DbContextOptions<ProExpenseDbContext> options) : base(options)
        {
                
        }
    }
}
