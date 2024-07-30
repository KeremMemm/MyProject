using BankAccountForm.Contexts;
using BankAccountForm.Entities.Accounts;
using BankAccountForm.Interfaces.Accounts;
using BankAccountForm.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Managers.Accounts
{
    internal class CustomerManager
        : GenericManager<Customer>, ICustomerManager
    {
        public async Task<IEnumerable<CustomerViewModel>> GetCustomerWithDetail()
        {
           return await  _bankContext.Customers
                .Include(x=>x.CustomerWorkDetail)
                .Select(x=> new CustomerViewModel
                {
                    Id = x.Id,
                    Experience = x.CustomerWorkDetail.Experience,
                    Company = x.CustomerWorkDetail.CompanyName,
                    FullName = x.FullName,
                    Salary = x.CustomerWorkDetail.Salary,
                }).ToListAsync();
        }

        public async Task<Customer> GetCustomerWithDetailById(int id)
        {
            return await _bankContext.Customers
                   .Include(x => x.CustomerWorkDetail)
                   .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
