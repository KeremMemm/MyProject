using BankAccountForm.Contexts;
using BankAccountForm.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Managers
{
    internal class GenericManager<T> : IGenericManager<T> where T : class, new()
    {
        protected readonly BankContext _bankContext;

        public GenericManager()
        {
            _bankContext = new BankContext();
        }

        public async Task Add(T entity)
        {
            await _bankContext.Set<T>().AddAsync(entity);
        }

        public  void Delete(T entity)
        {
             _bankContext.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return  await _bankContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _bankContext.Set<T>().FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _bankContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _bankContext.Set<T>().Update(entity);
        }
    }
}
