namespace BankApplicationForUniser.Entities
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
