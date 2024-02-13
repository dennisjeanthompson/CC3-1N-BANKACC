#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classec
{
    public class InterestEarningAccount : BankAccount

    {
        public InterestEarningAccount(string owner,decimal initialBalance) : base(owner,initialBalance)
        {

        }
        public override void PerformMonthEndTransactions()
        {
           
                if (Balance > 500m)
                {
                    decimal interest = Balance * 0.02m;
                    MakeDeposit(interest, DateTime.Now, " apply monthly interest to this mf!");

                }
            
        }

    }
}
