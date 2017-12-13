using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Transaction_List class. Contains the Create_Transaction, Get_Balance, and Get_History methods

namespace AltSoureBankingLibrary
{
    public class Transaction_List
    {
        private List<Transaction> transactions = new List<Transaction>() ;

        //Creates a new transaction entry in the transaction list. 
        public string Create_Transaction(double amount, string transaction_type, double prev_balance)
        {
            if (transaction_type == "withdraw")//If the transaction type is a withdrawal, check for an overdraw.
            {
                if(Get_Balance() < amount)
                {
                    return "Insufficient Funds";
                }
            }

            transactions.Add(new Transaction(amount, transaction_type, prev_balance)); //If no overdraw occurs, add withdraw transaction into the transaction_list
            return "Transaction Complete. Press any key to continue...";
        }

        //Get_Balance method iterates through transactions, adding and subtracting values from transaction history until current balance is calculated
        public double Get_Balance()
        {
            double balance = 0; //Initialize balance 

            //Look through all transactions in list, adding the deposit amount while subtracting the withdrawal amount. 
            foreach(Transaction t in transactions)
            {
                string transaction_type = t.Get_Type();

                if(transaction_type == "deposit")
                {
                    balance += t.Get_Amount();
                }
                else if(transaction_type == "withdraw")
                {

                 balance -= t.Get_Amount();
                    
                }
                
            }
            return balance;
        }

        //Returns an array of the transaction history
        public Transaction[] Get_History()
        {
            return transactions.ToArray();
        }
        

    }
}
