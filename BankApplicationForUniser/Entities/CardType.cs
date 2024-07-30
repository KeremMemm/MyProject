namespace BankApplicationForUniser.Entities
{
    public class CardType
    {
        public CardType()
        {
            BankCards = new HashSet<BankCard>();
        }
        public int Id { get; set; }
        public string Value { get; set; }
        public  ICollection<BankCard> BankCards { get; set; }
    }
}
