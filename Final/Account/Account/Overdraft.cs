using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Overdraft:Account
    {
        public Overdraft() { }
        public Overdraft(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {

        }
        public double Limit = 5000;
        public override void Withdraw(double amount)
        {
            if (amount <= Balance+Limit)
            {
                Balance -= amount;
                Console.WriteLine("Your acc has been debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public override void Transfer(Account acc, double amount)
        {
            if (amount <= Balance)
            {
                this.Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("Your acc has been debited by {0} to {1}({2})", amount, acc.AccName, acc.AccNo);
            }
        }
    }
}
