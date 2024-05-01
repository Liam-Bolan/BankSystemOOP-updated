using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemOOP
{

    class Bank
    {
        //attributes
        private Dictionary<int, Account> Accounts = new Dictionary<int, Account>();


        //methods
        public void AddAccount(Account A)
        {
            // add(key value, account object)
            Accounts.Add(A.accountNumber, A);

        }

        public void AddAccount(GoldAccount GA) //overloaded method (same name, different parameters)
        {
            
 
        }

        public Account FindAccount()
        {
                Console.Write("Enter Account Number: ");
                int AccountNumber = Int32.Parse(Console.ReadLine());
                Account AccountToFind;
                //find this account in the dictionary

                // does the Account exist?
                if (Accounts.ContainsKey(AccountNumber))
                    {
                    //yes
                    AccountToFind = Accounts[AccountNumber];
                    return AccountToFind;

                    }
                    else
                    {
                    //no
                    Console.WriteLine("No Account Found");
                    return null;
                    }
        }

        public GoldAccount FindGoldAccount()
        {
            Console.Write("Enter Account Number: ");
            int AccountNumber = Int32.Parse(Console.ReadLine());
            GoldAccount AccountToFind;
            //find this account in the dictionary
            return null; 
   
            
        }
    }
}
