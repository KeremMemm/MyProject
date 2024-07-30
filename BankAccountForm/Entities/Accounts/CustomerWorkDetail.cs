using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Entities.Accounts
{
    public class CustomerWorkDetail
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        private float salary;
        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 250)
                {
                    throw new Exception("Salary must be greater than 250");
                }
                salary = value;
            }
        }

        public int Experience { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
