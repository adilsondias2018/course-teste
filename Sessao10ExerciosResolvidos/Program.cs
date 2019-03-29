using System;
using System.Collections.Generic;
using Sessao10ExerciosResolvidos.Entities;
using System.Globalization;

namespace Sessao10ExerciosResolvidos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> listaEmpregados = new List<Employee>();
            Console.WriteLine("Entre com a quantidade de funcionáros");
            int numeroFuncinario = int.Parse(Console.ReadLine());


            for(int i=0; i<numeroFuncinario; i++)
            { // inicio for

                Console.WriteLine("O Funcionário é terceirizado ");
                char terceirizado = char.Parse(Console.ReadLine());
               
               
                    Console.WriteLine("Informe o nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe numero de horas trabalhas: ");
                    int numeroHoras = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor da hora: ");
                    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(terceirizado == 's' || terceirizado == 'S')
                {
                    Console.WriteLine("Informe o valor da hora: ");
                    double valorAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    // chamando a lista para adicionar os valores

                    listaEmpregados.Add(new OutsouredEmployee(nome, numeroHoras, valorHora, valorAdicional));
                }
                else
                {
                    listaEmpregados.Add(new Employee(nome, numeroHoras, valorHora));
                }

                                           

            }// fim for

            Console.WriteLine("===================");
            Console.WriteLine("Pagamentos");
            Console.WriteLine("===================");

            foreach (Employee emp in listaEmpregados)
            {
                Console.WriteLine( "nome:" + emp.Name + "-" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture) );
            }

        }
    }
}
