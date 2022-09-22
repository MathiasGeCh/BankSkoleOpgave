using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSkoleOpgave
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount(100);
            while (true)
            {
                Console.WriteLine("Pick your option");
                Console.WriteLine("To show balance press 1");
                Console.WriteLine("For deposit press 2");
                Console.WriteLine("For withdrawal press 3");
                Console.WriteLine();

                ConsoleKeyInfo keyinput = Console.ReadKey(true);
                int input = int.Parse(keyinput.KeyChar.ToString());

                switch (input)
                {
                    case 1:
                        bank1.GetBalance();
                        Console.WriteLine();
                        break;
                    case 2:
                        bank1.Deposit();
                        Console.WriteLine();
                        break;
                    case 3:
                        bank1.Withdraw();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        Console.WriteLine();
                        break;

                }
            }
        }

    }
}