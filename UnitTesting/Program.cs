using System;

namespace UnitTesting
{
    public class Program
    {
        // Global Variable for use by all methods
        public static decimal balance = 50_000m;

        public static void Main(string[] args)
        {
            bool action = true;
            while(action)
            {
                // User menu
                Console.WriteLine("Welcome to Automated Teller Machine. Please make a selection from the following options.");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit Session");

                // User input error handling
                try
                {
                    // Get user choice for menu
                    int userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1: // Deposit
                            Console.WriteLine("Enter an amount to deposit.");
                            // Collect User Input
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            // Pass value to method and format response
                            Console.WriteLine($"Current balance: {Deposit(depositAmount).ToString("C")}");
                            break;
                        case 2: // Withdraw
                            Console.WriteLine("Enter an amount to withdraw.");
                            // Collect User Input
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            // Pass value to method and format response
                            Console.WriteLine($"Current Balance: {Withdraw(withdrawAmount).ToString("C")}");
                            break;
                        case 3: // Current Balance
                            Console.WriteLine($"Current Balance: {GetBalance().ToString("C")}");
                            break;
                        default: // Any other option: terminate session
                            Console.WriteLine("Session Terminated. Have a nice day.");
                            Environment.Exit(0);
                            break;
                    }
                }
                // Catch any error
                catch (Exception e)
                {
                    Console.WriteLine($"Error message: {e.Message}");
                }
                // Ask the user if they wish to continue
                finally
                {
                    Console.WriteLine("Do you wish to make another transaction? (y/n)");
                    string userResponse = Console.ReadLine();
                    action = userResponse == "y" ? action = true : action = false;
                    if(!action) Console.WriteLine("Session Terminated. Have a nice day.");
                }
            }
        }

        public static decimal Deposit(decimal money)
        {
            // Ensures that the user is depositing a positive value
            if (money > 0)
                balance += money;
            else
                throw new Exception("Parameter cannot be negative!");
            return GetBalance();
        }
        
        public static decimal Withdraw(decimal money)
        {
            // Ensures that the user is depositing a positive value and ensures that the user does not overdraw
            if (money > 0 && money < balance)
                balance -= money;
            else
            {
                if(balance < money)
                    throw new Exception("Cannot Overdraw Account!");
                else
                    throw new Exception("Parameter cannot be negative!");
            }
            return GetBalance();
        }

        // Returns current balance
        public static decimal GetBalance()
        {
            return balance;
        }
    }
}
