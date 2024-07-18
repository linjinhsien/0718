using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class DataGenerator
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExpenseContext(
             serviceProvider.GetRequiredService<DbContextOptions<ExpenseContext>>()))
            {
                // Look for any expenses.
                if (context.Expenses.Any())
                {
                    return;   // Data was already seeded
                }
                context.Expenses.AddRange(
            new Expense
            {
                Date = DateTime.Parse("2021-01-01"),
                Description = "衣服",
                Amount = 3000,
                Category = "衣"
            },
            new Expense
            {
                Date = DateTime.Parse("2021-01-02"),
                Description = "餐費",
                Amount = 1500,
                Category = "食"
            },
            new Expense
            {
                Date = DateTime.Parse("2021-01-03"),
                Description = "房租",
                Amount = 12000,
                Category = "住"
            },
            new Expense
            {
                Date = DateTime.Parse("2021-01-04"),
                Description = "機車燃油費",
                Amount = 1000,
                Category = "行"
            });


                context.SaveChanges();
            }
        }
    }

}