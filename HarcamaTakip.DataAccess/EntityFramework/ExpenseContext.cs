using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarcamaTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HarcamaTakip.DataAccess.EntityFramework
{
    public class ExpenseContext: DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L8F1FGT\SQLEXPRESS01;Database=ExpenseDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Expense>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");
        }
        public DbSet<Expense> Expenses { get; set; }
    }
}
