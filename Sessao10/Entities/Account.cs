using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao10.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        // private o valor nao pode ser alterado fora da clase principal
        // protected o valor só pode ser alterado na classe principal ou de uma que herde dela.




        public Account()
        {


        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw (double amount) // saque 
            // Com o uso da palavra virtual é possível fazer com que essa operação possa ser reescrita para desenpenhar outras funçoes na aplicação.
        {

            Balance -= amount + 5.0;


        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }
    }
}
