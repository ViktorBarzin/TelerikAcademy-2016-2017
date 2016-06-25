using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    abstract class Account
    {
        protected Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public Customer Customer { get;private set; }

        public decimal Balance { get;private set; }

        public decimal MonthlyInterestRate { get; set; }

        public virtual decimal CalculateInterestAmount(int months)
        {
            return this.MonthlyInterestRate * months;
        }
    }
}
