namespace BankAccountForm.Entities.Accounts
{
    public class Customer
    {
        public Customer()
        {
            BankCards = new HashSet<BankCard>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => FirstName + " " + LastName; }
        public CustomerWorkDetail CustomerWorkDetail { get; set; }

        public virtual ICollection<BankCard> BankCards { get; set; }

    }
}
