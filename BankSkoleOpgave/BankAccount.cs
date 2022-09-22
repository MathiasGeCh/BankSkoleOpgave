using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSkoleOpgave
{
    public class BankAccount
    {
        private decimal Balance;

        public BankAccount(decimal initialBankBalance)
        {
            Balance = initialBankBalance;
        }

        public void Withdraw()
        {
            Console.Write("Enter amount you wish to withdraw: ");
            int amount = 0;
            while (!int.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Please enter a number");
                Console.Write("Enter amount you wish to withdraw: ");
            }
            if(amount < 0)
            {
                Console.WriteLine("Withdraw failed. please enter positive number");
                return;
            }

            if ((Balance - amount) >= 0)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful. New balance = " + Balance);
            }
            else
            {
                Console.WriteLine("Withdrawal failed. Balance cant go negative");
            }

        }

        public void GetBalance()
        {
            Console.WriteLine($"This is your balance: {Balance}");
        }


        public void Deposit()
        {
            Console.Write("Enter amount you wish to deposit: ");
            int amount = 0;
            while (!int.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Please enter a number");
                Console.Write("Enter amount you wish to deposit: ");
            }
            if (amount < 0)
            {
                Console.WriteLine("Deposit failed. please enter positive number");
                return;
            }
            Balance += amount;
            Console.WriteLine("Deposit successful. New balance = " + Balance);
        }
    }






}
