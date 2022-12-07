using ATM.ClassLibrary.Classes;
using ATM.ClassLibrary.CustomEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ConsoleApp
{
    public class ATMConsole
    {
        public Session Session { get; set; }
        public ATMConsole(Session session)
        {
            Session = session;
            SetAccountHandlers();
            Authorize();
            DisplayMenu();
        }

        protected void SetAccountHandlers()
        {
            Session.SetAccountHandlers(authorizeHandler!, checkBalanceHandler!,
                putHandler!, withdrawHandler!, transferHandler!);
        }

        public void Authorize()
        {
            Console.Clear();
            Console.Write("\n\tAuthorization\n\n Card Number: ");
            string cardNumber = Console.ReadLine()!;
            Console.Write(" PIN: ");
            string password = SecureInputPassword();

            bool accountExists = Session.Authorize(cardNumber, password);
            if (!accountExists)
            {
                Console.Clear();
                Console.Write("\tAccount number is incorrect! Try again.\n\n");
                Authorize();
            }            
        }

        public string SecureInputPassword()
        {
            var password = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && password.Length > 0)
                {
                    Console.Write("\b \b");
                    password = password[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    password += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            return password;
        }

        void authorizeHandler(object sender, AuthorizeEventArgs e)
        {
            Console.Clear();
            if (e.Success == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Your password is incorrect!");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                Authorize();
            }
            else
            {
                Console.Write($"\n\n\tWelcome, {e.FullName}!");
                Thread.Sleep(800);                
                DisplayMenu();
            }
        }

        void checkBalanceHandler(object sender, CheckBalanceEventArgs e)
        {
            Console.WriteLine($"\n\tBalance: {e.Balance}$");
        }

        void withdrawHandler(object sender, WithdrawEventArgs e)
        {
            if (e.AccountBalanceLack)
                Console.WriteLine($"\n Lack of money on account balance!");
            else if (e.ATMCashLack)
                Console.WriteLine($"\n Lack of cash in ATM!");
            else
                Console.WriteLine($"\n Take your money.");
        }
        public void Withdraw()
        {
            int sum = 0;
            while (true)
            {
                Console.Write($"\n Sum: ");
                if (int.TryParse(Console.ReadLine(), out sum))
                {                    
                    Session.Withdraw(sum);
                    break;                 
                }
                else
                    Console.WriteLine($"\n Enter a valid sum.");
            }
        }

        void putHandler(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"\n Money got to your account balance safely.");
        }
        public void Put()
        {
            int amount = 0;
            while (true)
            {
                Console.Write($"\n Sum: ");
                if (int.TryParse(Console.ReadLine(), out amount))
                {
                        Session.Account.Put(amount);
                        break;                    
                }
                else
                    Console.WriteLine($"\n Enter a valid sum.");
            }
        }

        void transferHandler(object sender, TransferEventArgs e)
        {
            if (e.AccountBalanceLack)
                Console.WriteLine($"\n Lack of money on account balance!");
            else if (e.RecipientDoesntExist)
                Console.WriteLine($"\n Recipient account can not be fount.");
            else
                Console.WriteLine($"\n Money transfered successfully!");
        }
        public void Transfer()
        {
            string recipient;
            while (true)
            {
                Console.Write("\n Recipient card number: ");
                recipient = Console.ReadLine()!;
                if (Session.Bank.GetAccount(recipient) == null)
                    break;
                Console.Write("\n Enter a valid card number.");
            }

            int sum;
            while (true)
            {
                Console.Write($"\n Sum: ");
                if (int.TryParse(Console.ReadLine(), out sum))
                {
                    Session.Transfer(recipient, sum);
                    break;
                }
                else
                    Console.WriteLine($"\n Enter a valid sum.");
            }
        }

        public void Exit()
        {
            Authorize();
        }

        public void DisplayMenu()
        {
            Console.Clear();
            var options = new List<Tuple<string, Action>>()
            {
                new Tuple<string, Action>("Check balance", Session.CheckBalance),
                new Tuple<string, Action>("Withdraw", Withdraw),
                new Tuple<string, Action>("Put", Put),
                new Tuple<string, Action>("Transfer", Transfer),
                new Tuple<string, Action>("Exit", Exit)
            };

            string menu = "\n\tMenu\n\n";
            for (int i = 1; i <= options.Count; i++)
            {
                menu += $" {i} - {options[i-1].Item1}\n";
            }
            Console.Write(menu);

            int selected = 0;
            while (true)
            {
                Console.Write("\n Option: ");

                if (int.TryParse(Console.ReadLine(), out selected) == false || selected < 1 || selected > options.Count)
                    Console.WriteLine($"\nEnter a valid option number.");
                else break;
            }
            options[selected - 1].Item2();

            Console.Write("\n Press any key to continue.");
            var key = Console.ReadKey();
            DisplayMenu();           
        }       
    }
}

