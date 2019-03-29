using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sessao10.Entities;

namespace Sessao10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Inícios dos testes 001
               BusinessAccount account = new BusinessAccount(8080, "Adilson", 10000, 500);

               Console.WriteLine(account.Balance);

              // esse parte não funciona pois não é possível atribuir valor a não se direto na classe ou subclasse. account.Balance = 200.00;

           */


            /* Upcastin
             *  Casting da subclasse para superclasse
             *  Uso comum: Polimorfismo
             * 
             * DownCasting
             *  Casting da superclasse para subclasse
             *  Palavras as
             *  palavras is
             *  
             *  uso comum: métodos que recebem parâmetros geréricos (Ex: Equals)
             *  
             * 
             */


            /*/ Teste 002

            Account acc = new Account(1001, "Alex", 0.0); // objeto do tipo Account

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0); // objeto do tipo businessacoount

            //UPCASTING

            Account acc1 = bacc;

            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);

            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.1);

            // perceba que estamos convertendo um subclasse para um superclasse  bacc, BusinessAccount e SaveAccount sao subclasses que foram convertidas para superclasse;


            // Downcasting

            // BusinessAccount acc4 = acc2; || Para fazer essa conversão tenho que fazer um casting

            BusinessAccount acc4 = (BusinessAccount)acc2;

            acc4.Loan(100.0);

            // fazer com que um objeto businessAccount receba um SaveAcount

           // Erro ==> BusinessAccount acc5 = acc3;
          //  BusinessAccount acc6 = (BusinessAccount)acc3; // nesse caso não apresenta erro, mas o erro irá aparecer em tempo de execução;

            // Para resolver utilizamos o seguinte recurso 

            if( acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3; // Essa é uma forma de fazer o cast
                BusinessAccount acc5 = acc3 as BusinessAccount; // e também temos essa forma

                acc5.Loan(200.0);

                Console.WriteLine("Loan!");

            }

            if(acc3 is SavingsAccount)
            {
                 // SavingsAccount acc5 = (SavingsAccount)acc3; // Essa é uma forma de fazer o cast

                SavingsAccount acc5 = acc3 as SavingsAccount; //e também temos essa forma

                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }



            /* SOBREPOSIÇÃO OU SOBRESCRITA
             * 
             * É a implementação de um métodosde uma superclasse na subclase
             * 
             * Para ue um método comun ( não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo "virtual"
             * 
             * 
             *  Ao sobrescrever um método, devemos incluir nele o prefixo "override"
             */

            // final teste 002                                            


            // Início dos testes 3

            Account acc1 = new Account(1001, "Alex", 500.0);

            Account acc2 = new SavingsAccount(1001, "Anna", 500.0, 00.1);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);





        }
    }
}
