using HarcamaTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcamaTakip.Business.Abstract
{
    public interface IExpenseService
    {
        void Add(Expense expense);
        List<Expense> GetAll();
        void Delete(Expense expense);
    }
}
