using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ClassLibrary.CustomEventArgs
{
    public class TransferEventArgs : AccountEventArgs
    {
        public string RecipientCardNumber { get; set; }
        public int Sum { get; set; }
        public bool AccountBalanceLack { get; set; }
        public bool RecipientDoesntExist { get; set; }
        public TransferEventArgs(string fullName,
                                 string cardNumber,
                                 string recipientCardNumber,
                                 int sum,
                                 bool accountBalanceLack,
                                 bool recipientDoesntExist) : base(fullName, cardNumber)
        {
            RecipientCardNumber = recipientCardNumber;
            AccountBalanceLack = accountBalanceLack;
            RecipientDoesntExist = recipientDoesntExist;
            Sum = sum;
        }
    }
}
