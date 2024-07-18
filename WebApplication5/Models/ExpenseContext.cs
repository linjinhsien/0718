using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class ExpenseContext : DbContext //繼承自DbContext
    {
        #region 建構函式constructor

        public ExpenseContext(DbContextOptions<ExpenseContext> options)
            : base (options)
        { }
        
        #endregion
        
        #region 注入DbSet
         public DbSet <Expense> Expenses {get; set;}
        #endregion
    }
}
