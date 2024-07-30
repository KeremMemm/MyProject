using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountForm.Entities.Accounts
{
    public class CardType
    {
        public CardType()
        {
            BankCards = new HashSet<BankCard>();
        }
        public int Id { get; set; }
        public string Value { get; set; }
        public virtual ICollection<BankCard> BankCards { get; set; }
    }
}
