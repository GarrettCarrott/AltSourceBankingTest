using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Transaction class. Contains the transaction details and fetching methods for each transactionentry
namespace AltSoureBankingLibrary
{
    public class Transaction
    {
        private double transaction_amount = 0; 
        private string transaction_type = string.Empty; //Determines whether the transaction is a 'deposit' or 'withrdrawal' 
        private DateTime timestamp; //timestamp for transaction
        private double running_balance = 0; //Determines the previous balance prior to transaction

        public Transaction(double amount, string transaction_type, double prev_balance)
        {
            this.transaction_amount = amount;
            this.transaction_type = transaction_type;
            this.timestamp = DateTime.Now;
            this.running_balance = prev_balance;
        }

        //returns 'deposit' or 'withdraw'
        public string Get_Type()
        {
            return transaction_type;
        }

        //returns the amount deposited or withdrawn
        public double Get_Amount()
        {
            return transaction_amount;
        }

        //returns the timestamp for the transaction
        public DateTime Get_Date()
        {
            return timestamp;
        }

        //Returns the previous balance of the transaction
        public double Get_Balance()
        {
            return running_balance;
        }
    }
}
