using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    class MortageAccount : Account,IDepositable
    {
        public MortageAccount(Customer customer, decimal balance, decimal monthlyInterestRate) : base(customer, balance, monthlyInterestRate)
        {
        }

        public void Deposit(decimal amount)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            // 1/2 interest rate for 12 months should be the same as 6 months no interest rate. Or I am bad at iconomics.
            return base.CalculateInterestAmount(months - 6);
        }
    }
}
