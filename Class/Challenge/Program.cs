using System;

public class BankAccount
{
  public string AccountNumber { get; private set; }

  public double Balance { get; set; }

  public string OwnerName { get; set; }

  public BankAccount(string _accountNumber, double _balance, string _ownerName)
  {
    AccountNumber = _accountNumber;
    OwnerName = _ownerName;
    Balance = _balance;
  }

  public void Deposit(double amount)
  {
    if (amount > 0)
    {
      Balance += amount;
      Console.WriteLine($"Deposited ${amount}, New balance: {Balance}");
      DisplayAccountInfo();
    }
    else
    {
      Console.WriteLine("Deposit amount must be positive");
    }
  }

  public void Withdraw(double value)
  {
    if (value > 0 && value <= Balance)
    {
      Balance -= value;
      Console.WriteLine($"Withdrawn ${value}, New balance: {Balance}");
      DisplayAccountInfo();
    }
  }


  public void DisplayAccountInfo()
  {
    Console.WriteLine($"Account number: {AccountNumber}");
    Console.WriteLine($"Owner Name: {OwnerName}");
    Console.WriteLine($"Balance: {Balance:0.00}");
  }
}


class Program
{
  static void Main()
  {
    BankAccount myBankAccount = new BankAccount("123456789", 1000, "Wayne");
    myBankAccount.Deposit(100);
    myBankAccount.Withdraw(500);
    myBankAccount.Deposit(-100);


  }
}