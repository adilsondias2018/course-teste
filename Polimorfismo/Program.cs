using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polimorfismo.Entities;
using System.Globalization;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de funcion�rios");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());


            // quardandos os dados em uma lista

            List<Employee> listaEmpregados = new List<Employee>();

            for (int i =  0; i <= quantidadeFuncionarios; i++ )
            {
                Console.WriteLine($"funcion�rio #{i}"); // Lembrando para interporla��o funcionar temos que colocar um $ no come�o
                Console.WriteLine("O funcionario � terceirizado? (y/N)");
                char resp = char.Parse(Console.ReadLine());
               
                    Console.WriteLine("Informe o nome do funcionario");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe a quantidade de horas trabalhadas");
                    int quantidadehoras = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor por hora");
                    double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    

                if (resp == 'y')
                {
                    Console.WriteLine("Informe o valor adicional");
                    double valorAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listaEmpregados.Add(new OutsourceEmployee(nome, quantidadehoras, valorPorHora, valorAdicional));
                }
                else
                {
                    listaEmpregados.Add(new Employee(nome, quantidadehoras, valorPorHora));
                }



            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach(Employee emp in listaEmpregados)
            {
                Console.WriteLine(emp.Name + "-" + emp.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }

        }
    }
}
