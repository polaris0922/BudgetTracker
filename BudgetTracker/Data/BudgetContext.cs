using Microsoft.EntityFrameworkCore;
using BudgetTracker.Models;

namespace BudgetTracker.Data
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; } // 對應資料表
    }
}
