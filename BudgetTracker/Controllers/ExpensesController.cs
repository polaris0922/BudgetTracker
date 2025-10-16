using Microsoft.AspNetCore.Mvc;
using BudgetTracker.Data;
using BudgetTracker.Models;

namespace BudgetTracker.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly BudgetContext _context;

        // 透過建構函式注入 DbContext
        public ExpensesController(BudgetContext context)
        {
            _context = context;
        }

        // GET: /Expenses
        public IActionResult Index()
        {
            // 從資料庫中讀取所有支出
            var expenses = _context.Expenses.ToList();

            // 將資料傳給 View 顯示
            return View(expenses);
        }
    }
}
