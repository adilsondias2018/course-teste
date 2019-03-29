using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao10.Entities
{
    class BusinessAccount : Account  // AQUI TEMOS A RELAÇÃO DE HERANÇA DA CLASSE ACCOUNT 
    {
        public double LoanLimit { get; set; }



        public BusinessAccount()
        {
           

        }
        // como no construturo abaixo além a propriedade LoanLimit também teremos as outras propriedades recebidas da
        // classe Account

        public BusinessAccount (int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
            
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) // emprestimo
        {

            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Não é possível realizar o emprestimo para esse valor.");
            }

            

        }


    }
}
