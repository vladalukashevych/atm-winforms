using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ClassLibrary
{
    public class AutomatedTellerMachine
    {
        public string Id { get; private set; }
        public string Address { get; set; }
        public int Balance { get; set; }

        public AutomatedTellerMachine(string id, string address, int balance)
        {
            Id = id;
            Address = address;
            Balance = balance;
        }
    }
}
