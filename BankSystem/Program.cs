namespace BankSystem
{
  class Program
  {
    static void Main(string[] args){
      BankAccount ba1 = new BankAccount("Adrian", 10000);
      BankAccount ba2 = new BankAccount("Denzel", 9999);

      System.Console.WriteLine($"an account has been initialized for {ba1.Owner} with account number of {ba1.Number} and a balance of {ba1.Balance}");
      System.Console.WriteLine($"an account has been initialized for {ba2.Owner} with account number of {ba2.Number} and a balance of {ba2.Balance}");

      ba1.MakeDeposit(10000, "My second deposit");
      ba1.MakeWithdrawal(5000, "I want to buy myself a yacht");

      Console.WriteLine($"my balance is {ba1.Balance}");
      
      ba1.ShowTransactions();
      ba2.ShowTransactions();
    }
  }
}

