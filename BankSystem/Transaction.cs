namespace BankSystem
{
  class Transaction
  {
    public decimal Amount;
    public DateTime Date;
    public string Notes;

    public Transaction(decimal Amount, DateTime Date, string Notes)
    {
      this.Amount = Amount;
      this.Date = Date;
      this.Notes = Notes;
    }


  }
}