namespace BankApplicationForUniser.Entities;

public class BankCard
{
    public int Id { get; set; }
    public string CardNumber { get; set; }
    public DateTime EndDate { get; set; }
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
    public CardType CardType { get; set; }
    public int CardTypeId { get; set; }
    public Credit Credit { get; set; }
    public int? CreditId { get; set; }
}
