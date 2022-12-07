using ATM.ClassLibrary.CustomEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ClassLibrary
{
    public class Account
    {
        public string FullName { get; private set; }
        public string CardNumber { get; private set; }
        private string Password { get; set; }
        public int Balance { get; private set; }

        public Account(string fullName, string cardNumber, string password, int balance)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Password = password;
            Balance = balance;
        }

        public bool Authorize(string password)
        {
            return Password == password;
        }        

        public void Put(int sum)
        {
            Balance += sum;
        }        

        public bool Withdraw(int sum)
        {
            if (sum <= Balance)
            {                
                Balance -= sum;
                return true;
            }
            return false;
        }
    }
}
