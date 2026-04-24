using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarcamaTakip.Entities.Concrete;
using HarcamaTakip.DataAccess.Abstract;

namespace HarcamaTakip.DataAccess.EntityFramework
{
    public class EfExpenseDal : IExpenseDal
    {
        public void Add(Expense expense)
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                context.Expenses.Add(expense);
                context.SaveChanges();
            }
        }

        public List<Expense> GetAll()
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                return context.Expenses.ToList();
            }
        }


        public void Update(Expense expense)
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                context.Expenses.Update(expense);
                context.SaveChanges();
            }
        }

        public void Delete(Expense expense)
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                context.Expenses.Remove(expense);
                context.SaveChanges();
            }
        }

        public Expense GetById(int id)
        {
            using (ExpenseContext context = new ExpenseContext())
            {
                return context.Expenses.SingleOrDefault(e => e.Id == id);
            }
        }
    }
}
