using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    class SavingsAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingsAccount() 
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount) //metodo overrride para alterar a operação WithDraw para não ser cobrada a taxa
        {
            Balance -= amount;
        }


    }

}
