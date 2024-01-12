
using System;
using System.Text;

namespace BankingApp
{
    class Program
    {
        static string username = "admin";
        static string password = "123";
        static double balance = 0;

        static double withdrawalFee = 0.067;
        static double depositFee = 0.0;

        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            bool isLoggedIn = false;

            Console.WriteLine("welcome!");

            while (!isLoggedIn)
            {
                Console.Write("Username: ");
                string inputUsername = Console.ReadLine();

                Console.Write("Password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    isLoggedIn = true;
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Invalid credentials. Please try again.");
                }
            }

            while (isLoggedIn)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Deposit money");
                Console.WriteLine("4. Logout");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        WithdrawMoney();
                        break;
                    case "3":
                        DepositMoney();
                        break;
                    case "4":
                        isLoggedIn = false;
                        Console.WriteLine("Logged out successfully!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine("Your balance is: " + balance);
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("Choose an amount to withdraw:");
            Console.WriteLine("1. 500k");
            Console.WriteLine("2. 1000k");
            Console.WriteLine("3. 1500k");

            string option = Console.ReadLine();

            double amount = 0;
            double fee = 0;

            switch (option)
            {
                case "1":
                    amount = 500000;
                    break;
                case "2":
                    amount = 1000000;
                    break;
                case "3":
                    amount = 1500000;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    return;
            }

            fee = amount * withdrawalFee;

            if (amount <= balance - fee && amount % 50 == 0)
            {
                balance -= amount + fee;
                Console.WriteLine("Withdrawal successful!");
                Console.WriteLine("Fee: " + fee);
                Console.WriteLine("Remaining balance : " + balance);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please try again.");
            }
        }

        static void DepositMoney()
        {
            Console.WriteLine("Choose an amount to deposit:");
            Console.WriteLine("1. 500k");
            Console.WriteLine("2. 1000k");
            Console.WriteLine("3. 1500k");

            string option = Console.ReadLine();

            double amount = 0;
            double fee = 0;

            switch (option)
            {
                case "1":
                    amount = 500000;
                    break;
                case "2":
                    amount = 1000000;
                    break;
                case "3":
                    amount = 1500000;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    return;
            }

            fee = amount * depositFee;

            if (amount > 0)
            {
                balance += amount - fee;
                Console.WriteLine("Deposit successful!");
                Console.WriteLine("Fee: " + fee);
                Console.WriteLine("Remaining balance: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please try again.");
            }
        }
    }
}
















         
