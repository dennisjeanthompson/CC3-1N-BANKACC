#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classec
{
   public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string owner,decimal initialAmount,decimal creditLimit) : base (owner,initialAmount,-creditLimit)
        {
            
        }
        public override void PerformMonthEndTransactions()
        {
            if(Balance < 0)
            {
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge Monthly Interest to this mf");
            }
        }
        protected override Transaction? CheckWithDrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                return new Transaction(-20, DateTime.Now, "YOu need to pat");
            }
            else
            {
                return default;
            }
        }
    }
}
