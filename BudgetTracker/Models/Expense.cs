using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetTracker.Models
{
    public class Expense
    {
        [Key] // 主鍵
        public int Id { get; set; }

        [Required] // 必填欄位
        [StringLength(10)] // 最大長度
        public string Category { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        [StringLength(30)]
        public string Note { get; set; } // 備註，可選
    }
}
