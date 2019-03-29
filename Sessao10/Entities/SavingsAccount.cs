using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sessao10.Entities;


namespace Sessao10.Entities
{
    class SavingsAccount :Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()
        {

            Balance += Balance * InterestRate; 
         
        }

        public override void Withdraw(double amount) // Classe sobreposta com o uso do Virtual na classe amout.

        {
            base.Withdraw(amount); // chamando a operçaão padrão da classe amount
            Balance -= 2.0; // E também acresentado operações proprias para a operação atual com o uso do BASE
        }

    }
}
