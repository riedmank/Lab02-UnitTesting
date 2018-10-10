﻿using System;

namespace UnitTesting
{
    public class Program
    {
        public static decimal balance = 5000m;

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

                int userChoice = int.Parse(Console.ReadLine());
                
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Deposit");
                        break;
                    case 2:
                        Console.WriteLine("Withdraw");
                        break;
                    case 3:
                        Console.WriteLine("Check Balance");
                        break;
                    default:
                        Console.WriteLine("Session Terminated. Have a nice day.");
                        break;
                }

                Console.WriteLine("Do you wish to make another transaction? y/n");
                string userResponse = Console.ReadLine();
                action = userResponse == "y" ? action = true : action = false;
            }
        }

        public static decimal Deposit(decimal money)
        {
            return GetBalance();
        }
        
        public static decimal Withdraw(decimal money)
        {
            return GetBalance();
        }

        public static decimal GetBalance()
        {
            return balance;
        }
    }
}
