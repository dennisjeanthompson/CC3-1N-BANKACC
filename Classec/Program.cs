#nullable enable
using System;

namespace Classec
{
    class Program
    {
        static void Main(string[] args)
        {
			BankAccount account = new BankAccount("PDO",  10000);
            Console.WriteLine($"Account Number { account.AccountNumber} was created for{ account.Owner}the mf owner with {account.Balance} Billion pomoney");
            account.MakeWithdrawal (500, DateTime.Now, "Loto win for raping 4 year old");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Payment for sucking  a cock");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());
           /* try
            {
                account.MakeWithdrawal(750, DateTime.Now, "attempt to overwithdraw");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("CAUGHT TRYING TO OVERWITHDRAW TITS");
                Console.WriteLine(e.ToString());
            }*/
            BankAccount Mosteraccounts = new BankAccount("ass", 500);
            Console.WriteLine($"Account Number { Mosteraccounts.AccountNumber} was created for { Mosteraccounts.Owner} the mf owner with {Mosteraccounts.Balance} Billion pdomoney");
            account.MakeWithdrawal(300, DateTime.Now, "For Eating a babys genetelia");
            Console.WriteLine(account.Balance);

            GiftCardAccount giftCard = new GiftCardAccount("Gift Card", 100,50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "Get ped's Dildo");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Buy a Machete");
            giftCard.PerformMonthEndTransactions();
            giftCard.MakeDeposit(27.50m, DateTime.Now, "ADD FUNDS FOR liking a dk");
           // giftCard.PerformMonthEndTransactions();
            Console.WriteLine(" bALANCE OF GIFTCARD " + giftCard.Balance);

            var savings = new InterestEarningAccount("interestAcc",10000 );
            savings.MakeDeposit(750,DateTime.Now,"DIdo eatr");
            savings.MakeDeposit(1250, DateTime.Now, "Ck saer");
            savings.MakeWithdrawal(120, DateTime.Now, "Fr LOOT suing ss");
            savings.PerformMonthEndTransactions();
            Console.WriteLine("Balance of Savings "+savings.Balance);

            var credit = new LineOfCreditAccount("lineofcredit",0,500);
            //credit.MakeWithdrawal(150m, DateTime.Now, "PAYMENT FOR MOLESTATION");
            credit.MakeDeposit(100m,DateTime.Now,"Payment for killing Jesus");
            credit.MakeWithdrawal(5000,DateTime.Now,"for idk");
           // credit.PerformMonthEndTransactions();
            credit.PerformMonthEndTransactions();

            
            Console.WriteLine("Balance of Credit " + credit.Balance);
          /*  BankAccount InvalidBankAccount;
            try
            {
                InvalidBankAccount = new BankAccount("inavalid mf", 55);
            }
             catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creaing mf wrong value");
                Console.WriteLine(e.Message);
                return;
            }
          */

        }

    }
}
