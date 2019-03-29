using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sessao10ExerciosPropostos.Entities;

namespace Sessao10ExerciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listaProdutos = new List<Product>();

            Console.WriteLine("Entre com numero de produtos");
            int numeroProdutos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroProdutos; i++)
            {
                Console.WriteLine(" Produuto {i} é importado? (c/u/i/)");
                char opcao = char.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome do Prouto");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine("Informe o valor do produto");
                double preco = double.Parse(Console.ReadLine());


                if (opcao == 'i' || opcao == 'I')
                {
                    Console.WriteLine("Informe o valor da alfadega");
                    double alfandega = double.Parse(Console.ReadLine());

                    listaProdutos.Add(new ImportProduct(nomeProduto, preco, alfandega));
                }
                else if (opcao == 'u' || opcao == 'U')
                {
                    Console.WriteLine("Informe a data e fabricação do produto");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                    listaProdutos.Add(new UsedProduct(nomeProduto, preco, dataFabricacao));
                }
                else
                {
                    listaProdutos.Add(new Product(nomeProduto, preco));

                }


            }

            Console.WriteLine("=====Relatóiro===========");

            foreach (Product prod in listaProdutos)
            {

                Console.WriteLine(prod.etiquetaPreco());
            }

                
        }
    }
}
