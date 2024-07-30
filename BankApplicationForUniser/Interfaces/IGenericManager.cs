using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationForUniser.Interfaces
{
    public interface IGenericManager<T> where T : class, new()
    {
        public Task AddAsync(T entity);
        public void Update(T entity);
        public void Remove(T entity);
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task  SaveChangesAsync();
    }
}
