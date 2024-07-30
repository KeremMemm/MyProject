using BankApplicationForUniser.Entities;
using BankApplicationForUniser.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BankApplicationForUniser.Managers;

public class CustomerManager : GenericManager<Customer>, ICustomerManager
{
    public async Task<IEnumerable<Customer>> GetCustomersWithWorkDetail()
    {
        return await  _context.Customers
             .Include(x => x.CustomerWorkDetail)
             .ToListAsync();
    }

    public async Task<Customer?> GetCustomerWithWorkDetailById(int id)
    {
        return await _context.Customers
             .Include(x => x.CustomerWorkDetail)
             .FirstOrDefaultAsync(x => x.Id == id);
    }
}
