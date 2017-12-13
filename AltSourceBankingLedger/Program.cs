/*********************************************************
 * Project: AltSource Bankiing Test
 * Author: Garrett Pement
 * Date: 12/7/2017
 *********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AltSoureBankingLibrary;

namespace AltSourceBankingLedger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            AccountCollection accounts = new AccountCollection();
            while (input != "exit")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("\t Login Menu");
                Console.WriteLine("Login (1)");
                Console.WriteLine("Create Account (2)");
                Console.WriteLine("Exit (exit)");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Please type in your Username:");
                    string username = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine("Please type in your Password:");
                    string password = Console.ReadLine();
                    Account current_account;
                    try
                    {
                        current_account = accounts.Login(username, password);
                    

                    string account_input = string.Empty;

                    while (account_input != "5")
                    {
                        double number = 0;

                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("\t \t Welcome to Super Cool Bank!");
                        Console.WriteLine("Make a Deposit (1)");
                        Console.WriteLine("Make a Withdrawal (2)");
                        Console.WriteLine("Check Transaction History (3)");
                        Console.WriteLine("Check Current Balance (4)");
                        Console.WriteLine("Logout (5)");
                        Console.WriteLine("");

                        account_input = Console.ReadLine();
                        switch (account_input)
                        {
                            case "1":
                                Console.WriteLine("Please enter deposit amount:");
                                account_input = Console.ReadLine();
                                
                                if(double.TryParse(account_input, out number))
                                {
                                        Console.WriteLine(current_account.Deposit(number));
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                else
                                {
                                        Console.WriteLine("Invalid deposit amount. Press any key to continue...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                               
                                
                                break;

                            case "2":
                                Console.WriteLine("Please enter withdraw amount:");
                                account_input = Console.ReadLine();

                                    if (double.TryParse(account_input, out number))
                                    {
                                        Console.WriteLine(current_account.Withrdraw(number));
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Withrdraw amount. Press any key to continue...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    break;

                            case "3":
                                Console.WriteLine("Displaying transaction history...\n");
                                foreach(Transaction t in current_account.Get_History())
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Previous Balance: {0} | Transaction Type: {1} | Transaction amount: {2} | Date: {3}", t.Get_Balance(), t.Get_Type(), t.Get_Amount(), t.Get_Date());
                                }

                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case "4":
                                Console.WriteLine("Current Balance: ${0}", current_account.Get_Balance());
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                                break;




                        }
                    

                    }


                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        Console.Clear();

                    }


                }

                if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Please type in your Username:");
                    string username = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine("Please type in your Password:");
                    string password = Console.ReadLine();
                    try
                    {
                        accounts.Create_Account(username, password);
                        Console.WriteLine("Account Created! Please log in... ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        Console.Clear();
                    }
     
                    

                }                
            }
            



        }



    }
}
