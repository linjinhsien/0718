
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date{ get; set; }
        [Required]
        public string Description { get; set;}
        [Required]
        public double Amount {get; set;}
        public string Category {get;set;}
    }
}
