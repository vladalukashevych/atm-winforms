using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ClassLibrary.CustomEventArgs
{
    public class AccountEventArgs : EventArgs
    {
        public string FullName { get; private set; }
        public string CardNumber { get; private set; }

        public AccountEventArgs(string fullName, string cardNumber)
        {
            FullName = fullName;
            CardNumber = cardNumber;
        }
    }
}
