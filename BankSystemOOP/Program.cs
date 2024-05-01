using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemOOP
{
    class Program
    {
       // instantiate empty bank object as a global variable
       public static Bank ThisBank= new Bank();

        static void Main(string[] args)
        { 

            char option;
            Account ThisAccount;
            GoldAccount ThisGoldAccount;          

            do
            {
                Menu();
                option = Console.ReadLine().ToUpper()[0]; //collect option capitalised.
                switch (option)
                {
                    case '1':     //Add account
                        
                            AddAccount();
                            break;

                    case '2':    //View Account
                            Console.Clear();
                            //find the account in the bank
                            ThisAccount = ThisBank.FindAccount();

                            //if it exists
                            if (ThisAccount != null)
                            {
                                //run the view account method
                                ThisAccount.ViewAccount();
                            }
                            break;

                    case '3':  //deposit money into account
                        
                        ThisAccount = ThisBank.FindAccount();
                        Console.Write("How much money would you like to Deposit? £");
                        double amount = double.Parse(Console.ReadLine());
                        if (ThisAccount != null)
                        {
                            ThisAccount.accountBalance += amount;
                        }

                        // find the account in the bank first
                        //get the amount to deposit
                        //run the deposit method if the account exists

                        break;

                    case '4':   // withdraw money out account

                        ThisAccount = ThisBank.FindAccount();
                        Console.Write("How much money would you like to Withdraw? £");
                        amount = double.Parse(Console.ReadLine());
                        if (ThisAccount != null)
                        {
                            ThisAccount.accountBalance -= amount;
                        }

                        // find the account in the bank first
                        //get the amount to withdraw
                        //run the withdraw method  if the account exists

                        break;

                    case '5': //Add Gold account

                            AddGoldAccount();
                            break;

                    case '6': //View Gold Account balance
                            
                            
                            break;

                    case '7': //deposit money to gold account

                            // find the Gold account in the bank first
                            //get the amount to deposit
                            //run the deposit method

                            break;

                    case '8': // withdraw money from gold account account

                            // find the gold account in the bank first
                            //get the amount to withdraw
                            //run the withdraw method if the gold account exists
                            
                            break;               

                }

                Console.WriteLine();
                Console.WriteLine("Hit any key to continue");
                Console.ReadKey();
                Console.Clear();

            } while (option != 'Q');

        }

        static void Menu()
        {
         
            Console.WriteLine("MENU");
            Console.WriteLine("Accounts");
            Console.WriteLine(" 1. Create Account");
            Console.WriteLine(" 2. View Account");
            Console.WriteLine(" 3. Deposit to Account");
            Console.WriteLine(" 4. Withdraw from Account");
            Console.WriteLine("Gold Accounts");
            Console.WriteLine(" 5. Create Account");
            Console.WriteLine(" 6. View Account");
            Console.WriteLine(" 7. Deposit to Account");
            Console.WriteLine(" 8. Withdraw from Account");
            Console.WriteLine();
            Console.WriteLine(" Q. Quit");
            Console.WriteLine();
            Console.Write("Enter choice: ");
        }

        static void AddAccount()
        {
            Account NewAccount = new Account(); //instantiate an account object
            Console.Write("Enter Account Number: ");
            NewAccount.accountNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Your Name: ");
            NewAccount.accountName = Console.ReadLine();
            Console.Write("Enter Your Address: ");
            NewAccount.accountAddress = Console.ReadLine();
            Console.Write("Enter Your Date Of Birth: ");
            NewAccount.accountDOB = DateTime.Parse(Console.ReadLine());
            ThisBank.AddAccount(NewAccount); // add account to bank
            
        }

        static void AddGoldAccount()
        {
            GoldAccount NewGoldAccount = new GoldAccount();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Account Number:");

            
        }

    }
}
