using BankApplicationForUniser.Contexts;
using BankApplicationForUniser.Entities;
using BankApplicationForUniser.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BankApplicationForUniser.Managers
{
    public class BankCardManager : IBankCardManager
    {

        private readonly BankCardUniserContext _context;

        public BankCardManager()
        {
            _context = new BankCardUniserContext();
        }
        public async Task AddAsync(BankCard entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task<IEnumerable<BankCard>> GetAll()
        {
            return await _context.BankCards.ToListAsync();
        }

        public async Task<BankCard> GetById(int id)
        {
            return await  _context.BankCards.FindAsync(id);
        }

        public void Remove(BankCard entity)
        {
            _context.BankCards.Remove(entity);
        }

        public void Update(BankCard entity)
        {
            _context.BankCards.Update(entity);
        }
    }
}
