using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; } // primary key

        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }

        // need to add script on View(action) page
        //asp-validation-summary AND asp-validation-for
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Amount must be greater than 0!!!")]
        public int Amount { get; set; }

        // This doesn't need to be specified (optional)
        [DisplayName("Expense Type")]
        public int ExpenseTypeId { get; set; }

        // making a connection between two table!!
        // This instacne doesn't contain property values other than Id.
        [ForeignKey("ExpenseTypeId")]
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
