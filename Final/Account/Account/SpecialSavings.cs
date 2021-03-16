using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class SpecialSavings:Account
    {
        public SpecialSavings() { }
        public SpecialSavings(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {

        }
        
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= ((Balance*20)/100))
            {
                double v = Balance * 20;
                v
                    / 100.00 -= amount;
                Console.WriteLine("Your acc has been debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance: Min Balance 500");
            }
        }
        public override void Transfer(Account acc, double amount)
        {
            if (Balance - amount >= 500)
            {
                this.Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("Your acc has been debited by {0} to {1}({2})", amount, acc.AccName, acc.AccNo);
            }
        }

    }
}
