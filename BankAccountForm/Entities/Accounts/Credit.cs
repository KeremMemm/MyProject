using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Entities.Accounts
{
    public class Credit
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public float Percent { get; set; }
        public int BankCardId { get; set; }
        public BankCard BankCard { get; set; }
    }
}
