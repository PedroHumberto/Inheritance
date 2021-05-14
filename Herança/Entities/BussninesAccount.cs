using System;
using Herança.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    class BussninesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussninesAccount() 
        {
        }

        public BussninesAccount(int number, string holder, double balance, double loantLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loantLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {

                Balance += amount;
            }
        }



    }
}
