using System;
using System.Runtime.Remoting.Messaging;

public class Account
{
    //attributes
    private int _accountNumber;
    private double _accountBalance;
    private string _accountName;
    private string _accountAddress;
    private DateTime _accountDOB;
    public int accountNumber
    {
        get { return _accountNumber; }
        set { _accountNumber = value; }
    }
    public double accountBalance
    {
        get { return _accountBalance; }
        set { _accountBalance = value; }
    }
    public string accountName
    {
        get { return _accountName; }
        set { _accountName = value; }
    }
    public string accountAddress
    {
        get { return _accountAddress; }
        set { _accountAddress = value; }
    }
    public DateTime accountDOB
    {
        get { return _accountDOB; }
        set { _accountDOB = value; }
    }
    
    //methods

	public Account()
        //constructor
	{
        
        Console.WriteLine("Account created!");
    }

    public void ViewAccount()
    {
        Console.Clear();
        Console.WriteLine("Account Number: {0}", _accountNumber);
        Console.WriteLine("Balance: {0}", String.Format("{0:C}", _accountBalance));
        Console.WriteLine("Name: {0}", _accountName);
        Console.WriteLine("Address: {0}", _accountAddress);
        Console.WriteLine("Date of Birth: {0}", _accountDOB.ToShortDateString());
    }    

    public void Withdraw(double amount)
    {
       if(amount > _accountBalance || _accountBalance == 0)
        {
            Console.WriteLine("Insufficient amount of money");
        }
        else
        {
            string choice;
            Console.Write($"Are you sure you want to withdraw £{amount}? (y/n) ");
            choice = Console.ReadLine();
            choice = choice.ToUpper();
            if(choice == "Y")
            {
                _accountBalance -= amount;
            }
            else
            {
                return;
            }
        }
    }

    public void Deposit(double amount)
    {
      if(amount <= 0)
        {
            Console.WriteLine("Cannot deposit funds");
        }
        else
        {
            _accountBalance += amount;
        }
        
    }

    //----------------------
}
