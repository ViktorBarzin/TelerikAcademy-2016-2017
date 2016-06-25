using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    class LoanAccount : Account,IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal monthlyInterestRate) : base(customer, balance, monthlyInterestRate)
        {
        }

        public void Deposit(decimal amount)
        {

        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                return base.CalculateInterestAmount(months - 3);
            }

            return base.CalculateInterestAmount(months - 2);
        }
    }
}
