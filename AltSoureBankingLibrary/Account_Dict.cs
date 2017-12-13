using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This Account Collection class is a dictionary that stores all of the methods used for account creation and searching.
//Also contains all created accounts. 

namespace AltSoureBankingLibrary
{
    public class AccountCollection
    {
        private Dictionary<string, Account> accounts = new Dictionary<string, Account>(); //Dictionary containing all user ID's
        
        //Create Account method. Takes in an id and a password
        public string Create_Account(string id, string password)
        {
            //Checks if the id has already been created. 
            if (accounts.ContainsKey(id))
            {
                throw new Exception("Account ID not availaible.");
            }
            else
            {
                accounts.Add(id, new Account(id, password));
            }

            return "Account created";
        
        }

       //Retrieves the account based on a given ID
        public Account GetAccount(string id)
        {
            if (accounts.ContainsKey(id))
            {
                return accounts[id];
            }
            else
            {
                throw new Exception("Account not found");
            }
            
        }

        //The login method. Takes in a string and password, then sets the current account to matching Account. 
        public Account Login(string id, string password)
        {
            Account current_account = GetAccount(id); //Searches the Dictionairy for an account with matching ID

            if (current_account.Get_Password() == password) //checks for matching password
            {
                return current_account;
            }
            else
            {
                throw new Exception("Incorrect Password");
            }
        }

        
        
    }
}
