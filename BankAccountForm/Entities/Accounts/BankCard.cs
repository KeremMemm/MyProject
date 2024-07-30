using BankAccountForm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Entities.Accounts
{
    public class BankCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public DateTime EndDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CardTypeId { get; set; }
        public CardType CardType { get; set; }

        public Credit Credit { get; set; }

    }
}
