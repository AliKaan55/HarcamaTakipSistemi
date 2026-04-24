using HarcamaTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcamaTakip.DataAccess.Abstract
{
    public interface IExpenseDal
    {
        // Bir harcamayı veritabanına ekleme 
        void Add(Expense expense);

        // Bir harcamayı güncelleme 
        void Update(Expense expense);

        // Bir harcamayı silme 
        void Delete(Expense expense);

        // Tüm harcamaları listeleme 
        List<Expense> GetAll();

        // Tek bir harcamayı ID üzerinden getirme 
        Expense GetById(int id);
    }
}
