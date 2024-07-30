using BankApplicationForUniser.Entities;

namespace BankApplicationForUniser.Interfaces
{
    public interface IBankCardManager
    {
        public Task AddAsync(BankCard entity);
        public void Update(BankCard entity);
        public void Remove(BankCard entity);
        public Task<IEnumerable<BankCard>> GetAll();
        public Task<BankCard> GetById(int id);
    }
}
