namespace BankSystem
{
  class BankAccount
  {
    private string _Owner;
    public string Number { get; }

    public string Owner
    {
      get
      {
        return _Owner + "'s";
      }
      set
      {
        _Owner = "The " + value;
      }
    }

    public decimal Balance
    {
      get
      {
        decimal balance = 0;

        foreach (var transaction in AllTransactions)
        {
          balance += transaction.Amount;
        }

        return balance;
      }
    }

    private static int accountGenerator = 1234567890;
    private List<Transaction> AllTransactions = new List<Transaction>();

    public BankAccount(string Owner, decimal InitialBalance)
    {
      this.Number = accountGenerator.ToString();
      this._Owner = Owner;
      this.MakeDeposit(InitialBalance, "Initial Deposit");
      accountGenerator++;
    }

    public void MakeDeposit(decimal Amount, string Notes)
    {
      if (Amount <= 0)
      {
        throw new ArgumentOutOfRangeException("Please enter a valid amount");
      }

      AllTransactions.Add(new Transaction(Amount, DateTime.Now, Notes));
    }

    public void MakeWithdrawal(decimal Amount, string Notes)
    {
      if (this.Balance < Amount)
      {
        throw new InvalidOperationException("Not enough balance to withdraw");
      }

      AllTransactions.Add(new Transaction(-Amount, DateTime.Now, Notes));
    }

    public void ShowTransactions()
    {
      foreach (var transaction in AllTransactions)
      {
        Console.WriteLine($"Amount: {transaction.Amount} Date: {transaction.Date} Note: {transaction.Notes}");
      }
    }
  }
}