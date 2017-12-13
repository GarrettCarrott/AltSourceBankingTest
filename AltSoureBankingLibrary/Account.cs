using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Account class. Contains the transaction data, ID, and Password for a user's account. Also contains retrieval methods for account information. 

namespace AltSoureBankingLibrary
{
    public class Account
    {
        private string id = string.Empty;
        private string password = string.Empty;

        Transaction_List transactions = new Transaction_List(); //Initializes a transaction list for this account

        public Account(string id, string password)
        {
            this.id = id;
            this.password = password;
        }

        //Deposit method. 
        public string Deposit(double amount)
        {

            return transactions.Create_Transaction(amount, "deposit", transactions.Get_Balance());

        }
        
        //Withdraw method.
        public string Withrdraw(double amount)
        {
            return transactions.Create_Transaction(amount, "withdraw", transactions.Get_Balance());
        }

        //Returns the current balance for the account
        public double Get_Balance()
        {
            return transactions.Get_Balance();
        }

        //Returns the password for this account
        public string Get_Password()
        {
            return password;
        }

        //Returns the transaction history in an array.
        public Transaction[] Get_History()
        {
            return transactions.Get_History();
        }
    }
}
