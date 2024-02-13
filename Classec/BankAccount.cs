#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classec
{
    public class BankAccount
    {
        private static int s_AccountNumberSeed = 1234567890;
        private readonly decimal _minimumBalance;
        public string AccountNumber { get; set; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (Transaction transaction in _allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        private List<Transaction> _allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance):this(name,initialBalance,0)
        {
   
        }
         
        public BankAccount(string name,decimal initialBalance,decimal minimumBalance)
        {
            Owner = name;
            if(initialBalance > 0)
            {
                MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            }
            MakeDeposit(initialBalance, DateTime.Now, "youre mf initial BALANCE PEDO!!NO.1 IN THE UNIVERSE");
            AccountNumber = s_AccountNumberSeed.ToString();
            s_AccountNumberSeed++;
            _minimumBalance = minimumBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)

        {
            
            Transaction deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
            if (amount < 0)
            {
                throw new InvalidOperationException("deposit must be positive mf ");
            }
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            Transaction? overdraftTransaction = CheckWithDrawalLimit(Balance - amount < _minimumBalance);
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "deposit valid number less than you pedophile");
            }
        
            Transaction? withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
            {
                _allTransactions.Add(overdraftTransaction);
            }

            /*     if (Balance - amount < _minimumBalance)
                 {

                 }
                 Transaction withdraw = new Transaction(-amount, date, note);
                 _allTransactions.Add(withdraw);*/

        }
        protected virtual Transaction? CheckWithDrawalLimit(bool isOverdrawn)
            
        {
            if (isOverdrawn)
            {
                
                    throw new InvalidOperationException( "dont have enough money YOU CHILD MOLESTER!!");
            }
            else
            {
                return default;
            }
        }
        public string GetAccountHistory()
        {
            StringBuilder report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach(Transaction transaction in _allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Notes}");
            }

            return report.ToString();
        }
        public virtual void PerformMonthEndTransactions()
        { }

    }
}
