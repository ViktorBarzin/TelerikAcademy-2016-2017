using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    class DepositAccount : Account,IDepositable
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate) : base(customer, balance, monthlyInterestRate)
        {
        }

        public void Deposit(decimal amount)
        {
        }

        public void WithDraw(decimal amount)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance < 1000 && this.Balance > 0)
            {
                this.MonthlyInterestRate = 0;
            }

            return base.CalculateInterestAmount(months);
        }
    }
}
