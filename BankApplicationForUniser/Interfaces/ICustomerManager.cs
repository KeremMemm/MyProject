using BankApplicationForUniser.Entities;

namespace BankApplicationForUniser.Interfaces
{
    public interface ICustomerManager : IGenericManager<Customer>
    {
         Task<IEnumerable<Customer>> GetCustomersWithWorkDetail();
         Task<Customer> GetCustomerWithWorkDetailById(int id);
    }
}
