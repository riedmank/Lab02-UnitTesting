using System;

namespace UnitTesting
{
    public class Program
    {
        public static decimal balance = 50_000m;

        public static void Main(string[] args)
        {
            bool action = true;
            while(action)
            {
                Console.WriteLine("Welcome to Automated Teller Machine. Please make a selection from the following options.");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit Session");

                try
                {
                    int userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Enter an amount to deposit.");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            Console.WriteLine($"Current balance: {Deposit(depositAmount).ToString("C")}");
                            break;
                        case 2:
                            Console.WriteLine("Enter an amount to withdraw.");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            Console.WriteLine($"Current Balance: {Withdraw(withdrawAmount).ToString("C")}");
                            break;
                        case 3:
                            Console.WriteLine($"Current Balance: {GetBalance().ToString("C")}");
                            break;
                        default:
                            Console.WriteLine("Session Terminated. Have a nice day.");
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error message: {e.Message}");
                }
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
            if (money > 0)
                balance += money;
            else
                throw new Exception("Parameter cannot be negative!");
            return GetBalance();
        }
        
        public static decimal Withdraw(decimal money)
        {
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

        public static decimal GetBalance()
        {
            return balance;
        }
    }
}
