using BankAccountForm.Entities.Accounts;
using BankAccountForm.ViewModels;

namespace BankAccountForm.Interfaces.Accounts;

internal interface ICustomerManager : IGenericManager<Customer>
{
    Task<IEnumerable<CustomerViewModel>> GetCustomerWithDetail();

    Task<Customer> GetCustomerWithDetailById(int id);
}
