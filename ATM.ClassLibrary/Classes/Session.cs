using ATM.ClassLibrary.CustomEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ClassLibrary.Classes
{
    public class Session
    {
        public Bank Bank { get; private set; }
        public AutomatedTellerMachine ATM { get; private set; }
        public Account Account { get; private set; }
        public Session(Bank bank, int atmId)
        {
            Bank = bank;
            ATM = bank.ATMs[atmId];
        }

        public void SetAccountHandlers(EventHandler<AuthorizeEventArgs> authorizeEvent,
                                       EventHandler<CheckBalanceEventArgs> checkBalanceEvent,
                                       EventHandler<AccountEventArgs> putEvent,
                                       EventHandler<WithdrawEventArgs> withdrawEvent,
                                       EventHandler<TransferEventArgs> transferEvent)
        {
            AuthorizeEvent += authorizeEvent;
            CheckBalanceEvent += checkBalanceEvent;
            PutEvent += putEvent;
            WithdrawEvent += withdrawEvent;
            TransferEvent += transferEvent;
        }

        public void SetAuthorizeHandler(EventHandler<AuthorizeEventArgs> authorizeEvent)
        {
            AuthorizeEvent += authorizeEvent;
        }
        public void SetCheckBalanceHandler(EventHandler<CheckBalanceEventArgs> checkBalanceEvent)
        {
            CheckBalanceEvent += checkBalanceEvent;
        }
        public void SetPutHandler(EventHandler<AccountEventArgs> putEvent)
        {
            PutEvent += putEvent;
        }
        public void SetWithdrawHandler(EventHandler<WithdrawEventArgs> withdrawEvent)
        {
            WithdrawEvent += withdrawEvent;
        }
        public void SetTransferHandler(EventHandler<TransferEventArgs> transferEvent)
        {
            TransferEvent += transferEvent;
        }

        public void RemoveAuthorizeHandler(EventHandler<AuthorizeEventArgs> authorizeEvent)
        {
            AuthorizeEvent -= authorizeEvent;
        }
        public void RemoveCheckBalanceHandler(EventHandler<CheckBalanceEventArgs> checkBalanceEvent)
        {
            CheckBalanceEvent -= checkBalanceEvent;
        }
        public void RemovePutHandler(EventHandler<AccountEventArgs> putEvent)
        {
            PutEvent -= putEvent;
        }
        public void RemoveWithdrawHandler(EventHandler<WithdrawEventArgs> withdrawEvent)
        {
            WithdrawEvent -= withdrawEvent;
        }
        public void RemoveTransferHandler(EventHandler<TransferEventArgs> transferEvent)
        {
            TransferEvent -= transferEvent;
        }

        public void RemoveAccountHandlers(EventHandler<AuthorizeEventArgs> authorizeEvent,
                                          EventHandler<CheckBalanceEventArgs> checkBalanceEvent,
                                          EventHandler<AccountEventArgs> putEvent,
                                          EventHandler<WithdrawEventArgs> withdrawEvent,
                                          EventHandler<TransferEventArgs> transferEvent)
        {
            AuthorizeEvent -= authorizeEvent;
            CheckBalanceEvent -= checkBalanceEvent;
            PutEvent -= putEvent;
            WithdrawEvent -= withdrawEvent;
            TransferEvent -= transferEvent;
        }

        public bool Authorize(string cardNumber, string password)
        {
            Account = Bank.GetAccount(cardNumber);
            if (Account != null)
            {
                OnAuthorizeEvent(Account!.Authorize(password));
                return true;
            }
            return false;
        }
        public event EventHandler<AuthorizeEventArgs> AuthorizeEvent;
        protected void OnAuthorizeEvent(bool success)
        {
            if (AuthorizeEvent != null)
                AuthorizeEvent(this, new AuthorizeEventArgs(Account.FullName, Account.CardNumber, success));
        }

        public void CheckBalance()
        {
            OnCheckBalanceEvent(Account.Balance);
        }
        public event EventHandler<CheckBalanceEventArgs> CheckBalanceEvent;
        protected void OnCheckBalanceEvent(int balance)
        {
            if (CheckBalanceEvent != null)
                CheckBalanceEvent(this, new CheckBalanceEventArgs(Account.FullName, Account.CardNumber, balance));
        }

        public void Put(int sum)
        {
            Account.Put(sum);
            ATM.Balance += sum;
            OnPutEvent();
        }
        public event EventHandler<AccountEventArgs> PutEvent;
        protected void OnPutEvent()
        {
            if (PutEvent != null)
                PutEvent(this, new AccountEventArgs(Account.FullName, Account.CardNumber));
        }

        public void Withdraw(int sum)
        {
            bool atmCashLack = ATM.Balance < sum;
            bool accountBalanceLack = !Account.Withdraw(sum);
            ATM.Balance -= sum;
            OnWithdrawEvent(sum, atmCashLack, accountBalanceLack);
        }
        public event EventHandler<WithdrawEventArgs> WithdrawEvent;
        protected void OnWithdrawEvent(int amount, bool atmCashLack, bool accountBalanceLack)
        {
            if (WithdrawEvent != null)
                WithdrawEvent(this, new WithdrawEventArgs(Account.FullName, Account.CardNumber, atmCashLack, accountBalanceLack));
        }
        
        public void Transfer(string toCardNumber, int sum)
        {
            Account recipient = Bank.GetAccount(toCardNumber);
            bool accountBalanceLack = false;
            bool recipientDoesntExist = true;
            if (recipient != null)
            {
                recipientDoesntExist = false;
                accountBalanceLack = !Account.Withdraw(sum);
                if (!accountBalanceLack) recipient.Put(sum);
            }
            
            OnTransferEvent(toCardNumber, sum, accountBalanceLack, recipientDoesntExist);
        }
        public event EventHandler<TransferEventArgs> TransferEvent;
        protected void OnTransferEvent(string recipient, int sum, bool accountBalanceLack, bool recipientDoesntExist)
        {
            if (TransferEvent != null)
                TransferEvent(this, new TransferEventArgs(Account.FullName, Account.CardNumber,
                    recipient, sum, accountBalanceLack, recipientDoesntExist));
        }        
    }
}
