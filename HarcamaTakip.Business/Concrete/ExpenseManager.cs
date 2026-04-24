using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarcamaTakip.Business.Abstract;
using HarcamaTakip.DataAccess.Abstract;
using HarcamaTakip.Entities.Concrete;

namespace HarcamaTakip.Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        private readonly IExpenseDal _expenseDal;
        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }
        public void Add(Expense expense)
        {
            
            if (expense.Amount <= 0)
            {
                throw new Exception("Harcama tutarı 0'dan büyük olmalıdır.");
            }

            if (string.IsNullOrEmpty(expense.Description))
            {
                throw new Exception("Harcama açıklaması boş bırakılamaz.");
            }

            
            _expenseDal.Add(expense);
        }
        public void Delete(Expense expense)
        {
            
            _expenseDal.Delete(expense);
        }

        public List<Expense> GetAll()
        {
            
            return _expenseDal.GetAll();
        }
    }
}
