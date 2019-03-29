using Course.Entities;
using Course.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;



namespace Course
{
    class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            /* estrutur while
            Console.Write("Digite um número");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (a >= 0.0)
            {

                double raiz = Math.Sqrt(a);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um número");
                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            
            Console.WriteLine("Quantos números");
            int n = int.Parse(Console.ReadLine());


            for(int i=1; i <= n; i++)
            {
                Console.WriteLine("oi");
            }

            Console.WriteLine("Numero Negativo");
          

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);


            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " +areaX.ToString("F4", CultureInfo.InstalledUICulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InstalledUICulture));
            if (areaX > areaY)
            {
                Console.WriteLine("O maior é" + areaX);
            }
            else
            {
                Console.WriteLine("O maior é" + areaY);
            }
             */

            /*
            // ############################################# PROGRAMA PRODUTOS ###############################################
            // OBSERVE A SUBSTITUIÇÃO DAS VARIÁVEIS PELA CLASSE

            Triangulo x, y; // perceba que declaramos dois objetos do tipo triangulo

            x = new Triangulo(); // agora estamos instanciando as duas classe e agora assim elas estão na áreade HEAP.

            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triângulo X:");

            // OBSERVE QUE PARA ACESSAR O ATRIBUTO DENTRO DA CLASSE BASTA ACESSA O OBJETO INSTANCIADO E ESCOLHER O ATRIBUTO DENTRO DESSE OBJETO.

             x.A= double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            // OBSERVER QUE SEMPRE ACESSO O OBJETO DA MESMA FORMA.

            // sem o metodo para o caluldo da area
             double p = (x.A + x.B + x.C) / 2.0;

            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            // ##### Utilizando o metódo calculo da area ###############
           // Perceba que o corpo prinicipal ficou ainda mais facil.
           double areaX1 = x.Area();
           double areaY1 = y.Area();
           


            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InstalledUICulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InstalledUICulture));

            Console.WriteLine("Área de X = " + areaX1.ToString("F4", CultureInfo.InstalledUICulture));
            Console.WriteLine("Área de Y = " + areaY1.ToString("F4", CultureInfo.InstalledUICulture));

            if (areaX > areaY)
            {
                Console.WriteLine("O maior é" + areaX);
            }
            else
            {
                Console.WriteLine("O maior é" + areaY);
            }
            */
            // ############################################# FIM PROGRAMA TRIANGULO ###############################################

            /*
            // exercicios classe pessoa

            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Informe os dados da primeira pessoa");

            a.Nome = Console.ReadLine();
            a.Idade= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe os dados da segunda pessoa");

            b.Nome = Console.ReadLine();
            b.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados pessoa 1" + "Nome" + a.Nome + "Idade" + a.Idade);
            Console.WriteLine("Dados pessoa 2" + "Nome" + b.Nome + "Idade" + b.Idade);

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa 1 é mais velhaa");
            }
            else
            {
                Console.WriteLine("Pessoa 2 é mais velhaa");
            }

            double mediaSalario = ((a.Salario + b.Salario) / 2.0);

            Console.WriteLine("A média de salário é: " + mediaSalario.ToString("F3", CultureInfo.InvariantCulture));


            */

            // ############################################# INÍCIO PROGRAMA PRODUTOS ###############################################

            // declarando a classe
            /*
           
           Produto p1, p2, p3, p4, p5;
            
           // instanciando o classe produto

           

           


           // #### Importante receber os dados em uma variável auxiliar para repassar para a classe


           Console.WriteLine("Entre dos dados do Prodyuto");
           Console.WriteLine("Nome:");
           string nome = Console.ReadLine();
           Console.WriteLine("Preço:");
           double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.WriteLine("Quatidade:");
           int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // ###  passando os dados para para o construtor 

            p1 = new Produto(nome, preco, quantidade);
            p2 = new Produto(); // como tenho um construtor padrao também posso usar assim.
            p3 = new Produto(nome, preco, 5); // também posso usar assim pois tenho uma sobrecarga para esse tipo de construtor

            // UMA OUTRA DE INICIAR VALORES NO C# BASTA SEGUIR O EXEMPLO ABAIXO

            p4 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };
            // GOSTOU DESSA OUTRA FORMA SHOW NÉ!!

            // Imprimindo os dados dos Produtos que se encontram na classe

            // Primeira forma 

            Console.WriteLine("Dados do Produto" + "Produto =>"  + p1.Nome + "$ =>" + p1.Preco.ToString("f3", CultureInfo.InvariantCulture) + "Quantidade =>"+ p1.Quantidade);
           Console.WriteLine("----------------------------------------");
           Console.WriteLine("Dados do Produto" + p1);
           Console.WriteLine("----------------------------------------");
           Console.WriteLine("Informe o numero de produtos a serem adcionados");
           int qte = int.Parse(Console.ReadLine());

           p1.AdcionarProduto(qte);

           Console.WriteLine("Dados atualizados " + p1);

           Console.WriteLine("----------------------------------------");
           Console.WriteLine("Informe o numero de produtos a serem removidos");
            qte = int.Parse(Console.ReadLine());

           p1.RemoverProdutos(qte);

           Console.WriteLine("Dados atualizados " + p1);

           
            
            p5 = new Produto("TV", 500.00, 15);

            p5.SetNome("TV 4K");

            Console.WriteLine(p5.GetNome() + p5.GetPreco() + p5.GetQuantidade());

            // Imprimindo os valores com ajuda das Propiedades ou properties

            Console.WriteLine("Utilzando as Propriedades ou Properties");

            // alterando o valor 
            p5.NomeProprieties = "Tv 01";

            // acessando o valor 
            Console.WriteLine(p5.NomeProprieties);

            // PERCEBA QUE NO MESMO MÉTODO UTILZAMOS O GET E O SET SE NOS PREOCUPARMOS EM CHAMAR UM NOVO METODO.

            Console.WriteLine(p5.NomeProprieties + p5.PrecoPropertiess + p5.QuantidadeProperties);


            // se tentarmos mudar o valor do preço e quantidade não iriamos enxergar o metodos set para os mesmo.
            // muito doido isso.

            */



            // ############################################# FIM PROGRAMA PRODUTOS ###############################################

            /*
            // ############################################# INÍCIO PROGRAMA RETANGULO ###############################################

            // declarando a classe

            Retangulo r;

            // Instanciando a classe;

            r = new Retangulo();
           

            Console.WriteLine("Entre com a Largura e Altura do retangulo");

            Console.Write("Largura:" );
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("------------Resultados---------------" + r);
            */
            // ############################################# FIM PROGRAMA RETANGULO ###############################################


            // ############################################# TEORIA MEMBROS ESTATICOS ###############################################

            /* 
             *  A CLASSE UTILITÁRIA: É UMA CLASSE QUE JÁ EXIXTE UM EXEMPLO NOSSO AQUI E A CLASSE MATH.SQRT() QUE JÁ UTILIZAMOS ALGUMAS VEZES
             * 
             * VAMOS A UM EXEMPLO 
             * 
             * FAZER UM PROGRAM APARA LER UM VALOR NUM´RIO QUALQUER, E DAÍ MOSTRAR QUANTO SERIA O VALRO DEUM CIRCUNFERÊNCIA E DO VUME DE UM ESFERA PARA
             * UM RAIO DAQUELE VALOR. INFORMAR TAMBÉM O VALOR DE PI COM DUAS CASAS DECIMAIS
             * 
             */

            // ############################################# EXEMPLO STATIC ###############################################
            /*
            Console.WriteLine("Entre com o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double volume = Volume(raio);

          

            Console.WriteLine("Circunferência" + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume" + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("VAlor de PI" + pi.ToString("f2", CultureInfo.InvariantCulture));

            // O exemplo abaixo utilizamos o mesmo conceito de static porém com o uso de classe

            // declarando a classe

            Calculadora calc;

            // instanciando a classe

            // calc = new Calculadora(); ==> como o objeto e estático não precisamos mais instanciar o objeto



            double circ1 = Calculadora.Pi;
            double volume1 = Calculadora.Volume(raio);

            Console.WriteLine("VAlor de PI" + circ1.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume" + volume1.ToString("f2", CultureInfo.InvariantCulture));


             */
            // ############################################# FIM EXEMPLO STATIC ###############################################


            // ############################################# INICIO EXRCICIO DOLAR ###############################################
            /*
            Console.WriteLine("Qual a cotaçao do dolar");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares você vai comprar");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double valorPago = Calculadora.ConversorDolar(cotacaoDolar, quantidadeDolar);

            Console.WriteLine("O valor a ser pago é: " + valorPago );

            */

            // ############################################# FIM  EXRCICIO DOLAR ###############################################


            //====>>>> 666666 <<<<====################# INICIO  MEMÓRIA ARRAYS  E LISTA SESSÃO 6   ##############################

            /*
            Point a;
            a = new Point();

            a.x = 10;
            a.y = 11;

            Console.WriteLine(a);

            a = new Point() ;



           

            Console.WriteLine(a);

            // NULLABLE ## É UM recurso de C# para que dados de tipo valor (structs) possam receber o valor null

            // Que quando tentei atribui um valor nullo na variável x do tipo doule ele não aceitoou. COMO RESOLVER ISSO?

            // double x = null;

            // Abaixo são apresentados as duas formas de se fazer isso. 
            // Uma forma mais longo e uma forma mais simplificada.
            Nullable<double> y = null;

            // E também temos a forma mais reduzida e usual.
            double? X =  null;

            //  O Nullable tem três métodos.

            double? y1 = 10.0;

            // Metodo GetValeuOrDefault());

            Console.WriteLine(X.GetValueOrDefault()); // nesse caso será impresso zero pois ainda não existe um valor padrão atribuito para o X 
            Console.WriteLine(y1.GetValueOrDefault()); // Agora será impressora o valor 10 pois temos o valor padrão para ele.

            Console.WriteLine( X.HasValue); // imprime false pois não tem o valor
            Console.WriteLine(y1.HasValue); // imprime true, pois possui o valor

           // ===>>  Console.WriteLine(X.Value); ||   // dará um erro informando que não foi definido um valor para isso trabalho com esse metodo da seguinte forma

            if (X.HasValue)
            {
                Console.WriteLine(X.Value);
            }else
            {
                Console.WriteLine("X não possui valor");
            }

            if (y1.HasValue)
            {
                Console.WriteLine(y1.Value);
            }
            else
            {
                Console.WriteLine("Y não possui valor");
            }


            // USO COMUN ## Campos de bando de dados que podem valer nulo ( data de nascimento, algum valor numérico) 
            // Dados de parametros opecionais

            // == Operador de Coalescência nula ==###################################################################V##



            double? x2 = null; 

            double? y2 = 10;

            double a1 = x2 ?? 5; // vou atribui o valor aq o valor de x2 caso esse valor seja null vou setalo com 5

            double b = y2 ?? 5; // vou atribuir o valor b o valor de y2 caso esse valor seja null vou setalo com 5

            Console.WriteLine(a1);
            Console.WriteLine(b);

            // VETORES PARTE 01 #################################

            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double[] vect = new double[n];

            ProdutVector[] VectProduct = new ProdutVector[n];

            for ( int i = 0; i<n; i++)
            {
                Console.WriteLine("Informe a altura");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            }

            double sum = 0.0;

            for(int i =0; i<n; i++)
            {
                sum += vect[i];  
            }

            double media = sum / 3;

            Console.WriteLine("A mádia é: " + media.ToString() );

            // trabalho com os objeto de uma classe dentro de um vetro

            for(int i= 0; i<n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                VectProduct[i] = new ProdutVector { Name = name, Price = price };

            }

            double sumV = 0.0;

            for(int i=0; i<n; i++)
            {
                sumV += VectProduct[i].Price;
            }

            double avg = sumV / n;

            Console.WriteLine("A mádia do vetor objeto  é: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            // ################ EXERCICIOS DE VETOR ####################################
         
            // quantidade de quarto disponíveis
            int Rooms = 3;


            ReservRoom[] Rreserve = new ReservRoom[Rooms];

            for (int i = 0; i<Rooms; i++)
            {
                Console.WriteLine(" Formless your name");
                string name = Console.ReadLine();
                Console.WriteLine("Formless your email");
                string email = Console.ReadLine();
                Console.WriteLine("Formless the mumber your room");
                int quarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (Rreserve[quarto] != null)
                {
                    Console.WriteLine("formless other room, thsi is reserved");
                    Console.WriteLine("Tray again");

                }
                else
                {
                    Rreserve[quarto] = new ReservRoom { Name = name, Email = email, Rom = quarto };


                }
              
            }

            Console.WriteLine(" Listagem de hospede" );

            for (int i = 0; i <Rooms; i++)
            {
                if(Rreserve[i] != null)
                
                    Console.WriteLine("\n Nome: " + Rreserve[i].Name + "\n Email: " + Rreserve[i].Email + "\n Quarto " + Rreserve[i].Rom);
                

                
            }
             

            // MODIFICADORES DE PARÂMETROS  #################################


            int s1 = Calculadora.Sum(new int[] { 2, 3 });

            int s2 = Calculadora.Sum(new int[] { 2, 3, 10, 10 , 56 });

            
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            // Agora vamos utilizar no mais a função soma com os params

            // perceba que ficou fácil

            int s3 = Calculadora.Soma(2, 3, 4); // perceba que ficou menso verbosos a passagem de parametro
            int s4 = Calculadora.Soma(1, 3, 56, 23, 54, 89, 1, 2, 3);


            Console.WriteLine(s3);
            Console.WriteLine(s4);

            // Muito legal o params né.




            // MODIFICADORES DE PARÂMETROS ref( FAZ O PARAMÊTRO SER UMA REFERÊNCIA PARA A VARIÁVEL ORIGINAL, EXIGINDO QUE A VARIÁVEL SEJA INICIADA ) 
            // e out ( FAZ O PARAMÊTRO SER UMA REFERÊNCIA PARA A VARIÁVEL ORIGINAL, NÃO EXIGE QUE A VARIÁVEL SEJA INICIADA ) 


            // REF 
            int a = 10;

            Calculadora.Triple( ref a); // IMPORTANTE, PERCEBA QUE TEM QUE USAR O REF TANTO NO METODO COM NO MAIN.


            Console.WriteLine(a);

            // OUT 
            int b = 10;
            int saida;


            Calculadora.Triple(b , out saida); // IMPORTANTE, PERCEBA QUE TEM QUE USAR O REF TANTO NO METODO COM NO MAIN.


            Console.WriteLine(saida);

            // considerações 
            /*
             * A variável passada como paramêtro  ref DEVE ter sido iniciada
             * A variávle passada como parametro out não precesa ter sido iniciada 
             * 
             * Ambos sã muito similares, mas ref é uma forma de fazer o compilador obriga o usuário a iniciar a variável.
             * 
             * Nota: ambos são considerados "code smells" ( design ruim) e devem ser evitados 
             */

            // boxing e unboxing

            // sintase for each

            // sintaxe opcional e simplificada para percorrer coleçoões  



            // LISTAS #################################

            // Vantagem de se trabalhar com lista em vez de vetor
            // Os tamanhos são variáveis 
            // Facilidade para se realizar inserções e deleçoes


            // Desvantagens:
            // Acesso sequencial aos elementos * Geralmente são otimizadas misturando o melhor da lista e dos vetores.


            //================>

            /*

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); // Adicionar um elemento e uma posição especifica da lista

            foreach (string obj in list) { 
                Console.WriteLine(obj);

            }

            // contagem dos elementos da lista
            Console.WriteLine("List count:" + list.Count);

            string s5 = list.Find( x=> x[0] =='A' ); // Na Find eu posso passar um função comun, mas tambem posso passar um função lambda.

            Console.WriteLine("First 'A':" + s5);

            string s6 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo 'A':" + s6);

            // Posição do primeiro A

            int pos1 = list.FindIndex(x => x[0] == 'A');

            Console.WriteLine("First position 'A':" + pos1);

            // Posição do ultimo A

            int pos2 = list.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("Last position 'A':" + pos2);

            // filtrar uma lista

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("------------------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remover elementos da list

            list.Remove("Alex");
            Console.WriteLine("------------------------------------------");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            // removendo todos 

            list.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("------------------------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Removendo elementos pela posição 

            list.RemoveAt(3);

            Console.WriteLine("------------------------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // removendo elementos de uma faixa

            list.RemoveRange(2, 2);

            Console.WriteLine("------------------------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            

            // MATRIZ #################################

            double[,] mat = new double[2, 3];

            // Decobrindo o tamanho da matriz

            Console.WriteLine(mat.Length);
            

            // Descobrindo o numero de linhas


            Console.WriteLine(mat.Rank);

            // Descobrindo o numero de linhas

            Console.WriteLine(mat.GetLength(0));

            // Descobrindo a quantidade de colunas

            Console.WriteLine(mat.GetLength(1));

          
            // exercicios resolvido 

            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int[,] matriz = new int[n, n];

            Console.WriteLine("Alimentando a matriz");

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {

                    matriz[i,j] = int.Parse(values[j]);

                }
            }

            Console.WriteLine("Main diagonal");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i,i] + " ");
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < n; j++)
                {
                 
                    if( matriz[i,j]< 0)
                    {
                        count += 1;
                    }

                }
            }


            Console.WriteLine("Valores negativos:" + count);

             

            // CONJUNTO  #################################

            // É uma coleção de objetos similar ao conceito de conjunto da Matemática

            /* Não há retição de elementos
             * Os elementos não tem uma "posição" dentro do conjunto
             * Oferece operações eficientes de conjunt: interseção, união, diferença, etc.
             *  
             */

            // classe HasSet

            /*

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);


            B.Add(3);
            B.Add(4);
            B.Add(5);
            B.Add(10);

            B.Remove(10);

            // A.ExceptWith(B);

            A.UnionWith(B);


            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Digite um valor inteiro");
            int N = int.Parse(Console.ReadLine());


            if (B.Contains(N))
            {
                Console.WriteLine(N + "pertence ao conjunto B");

            }else
            {
                Console.WriteLine(N + "não pertence ao conjunto B");

            }


            // Para pesquisa digite no google c# hasset

            */

            //====>>>> FIM  F666666 <<<<====################# INICIO  MEMÓRIA ARRAYS  E LISTA SESSÃO 6   ##############################
            //#########################################################################################################################





            //#########################################################################################################################
            //====>>>>INÍCIO 7777777<<<<====################# TIPOS ESPECIAIS C#  PARTE 1   ###########################################



            //### INFERÊNCIA

            // O var é muito bom para se utilizar variáveis como se fosse não tipadas, mas é importante ficar muito atento a possível perda de controle. 
            // Pois atribuiões podem ser feitas de forma incorreta e poderá gerar erros na aplicação
            /*
            var X = 10;
            var Y = 20.0;
            var Z = "mARIA ";

            Console.WriteLine(X);
            Console.WriteLine(Z);
            Console.WriteLine(Y);

            */
            //### SINTAXE ALTERNATIVA SWITE CASE

            /* A estrutura swite case é boa pra substituir os caso onde exita muitos if sel 
             * 
             

            int x = int.Parse(Console.ReadLine());
            string DAY;

            switch(x)
            {

                case 1:
                    DAY = "sunday";
                    break;
                case 2:
                    DAY = "Monday";
                    break;
                case 3:
                    DAY = "Tuesday";
                    break;
                case 4:
                    DAY = "Wednesday";
                    break;
                case 5:
                    DAY = "Thurday";
                    break;
                case 6:
                    DAY = "Friday";
                    break;
                case 7:
                    DAY = "Saturday";
                    break;
                default:
                    DAY = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + DAY);

            */
            //### SINTAXE ALTERNATIVA EXPRESSÃO CONDICIONAL TERNÁRIA

            /*

            double preco = double.Parse(Console.ReadLine());
            double desconto;

            if (preco > 20.0)
            {
                desconto = preco * 0.1;
            }else
            {
                desconto = preco * 0.05;

            }

            Console.WriteLine(desconto);


            // um forma alternativa seria aplicar o conceito de expressão ternária no qual teria o seguinte

            double desconto2 = (preco < 20.0) ? preco * 0.02 : preco * 0.05;
            */

            //### funções interessantes para string
            /*
            string original = " abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper();

            string s2 = original.ToLower();
            // retira espaços em branco do inicio e fim da estring no meio permanece;
            string s3 = original.Trim();
            // PEGAR A posição do início de uma cadeia de carateres
            int n1 = original.IndexOf("bc");
            // PEGAR A posição do final  de uma cadeia de carateres
            int n2 = original.IndexOf("DE");

            // Criando uma nova substring a partir de um ponto
            string s4 = original.Substring(5);
            string s5 = original.Substring(5, 5);

            // substituindo o valor pelo valor x
            string s6 = original.Replace('a', 'X');
            string s7 = original.Replace("abc", "XY");

            // verificando se a variável e vazia
            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);






            Console.WriteLine("ToUpper()" + s1);
            Console.WriteLine("ToLower()" + s2);
            Console.WriteLine("ToTrim)" + s3);
            Console.WriteLine("IndexOf)" + n1);
            Console.WriteLine("IndexLastOf)" + n2);
            Console.WriteLine("Substring)" + s4);
            Console.WriteLine("Substring )" + s5);
            Console.WriteLine("Substring a por x  )" + s6);
            Console.WriteLine("Substring a cadeia abc por XY"+ s7);
            Console.WriteLine("Verificando se a variável é nula ou vazia " + b1);
            Console.WriteLine("Verificando se a variável é nula ou vazia " + b2);
            */

            //### DATE TIME REPRESENTANDO HORA E TEMPO
            /*

          DateTime d1 = DateTime.Now;

          DateTime d2 = new DateTime(2018, 11, 25);
          DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3); // para imprimir 

          DateTime d4 = DateTime.Now;
          DateTime d5 = DateTime.Today;
          DateTime d6 = DateTime.UtcNow;

          Console.WriteLine(d1);

          Console.WriteLine(d1.Ticks);

          Console.WriteLine(d2);
          Console.WriteLine(d3);
          Console.WriteLine(d4);
          Console.WriteLine(d5);
          Console.WriteLine(d6);

          // convertendo a data

          DateTime d7 = DateTime.Parse("2000-08-15");
          DateTime d8 = DateTime.Parse("2000-08-15 13:02:12");

          DateTime d9 = DateTime.Parse("2000/08/15");
          DateTime d10 = DateTime.Parse("2000/08/15 13:02:12");

          // criando mascara para seus formatos de data hora
          DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
          DateTime d12 = DateTime.ParseExact("15/08/2015 13:05:00 ", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
          Console.WriteLine(d7);
          Console.WriteLine(d8);
          Console.WriteLine(d9);
          Console.WriteLine(d10);

          Console.WriteLine("===========formato data hora ================");

          Console.WriteLine(d11);
          Console.WriteLine(d12);

           */

            // OPERAÇÕES COM DATAS 

            /*
            DateTime d20 = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d20);
            Console.WriteLine(" 1) Date: " + d20.Date);
            Console.WriteLine(" 2) day: " + d20.Day);
            Console.WriteLine(" 3) DayOfWeek: " + d20.DayOfWeek);
            Console.WriteLine(" 4) DayOfYear: " + d20.DayOfYear);
            Console.WriteLine(" 5) Hour: " + d20.Hour);
            Console.WriteLine(" 6) Kind: " + d20.Kind);
            Console.WriteLine(" 7) Mellisecond: " + d20.Millisecond);
            Console.WriteLine(" 8) Minute: " + d20.Minute);
            Console.WriteLine(" 9) Month: " + d20.Month);
            Console.WriteLine(" 10) Second: " + d20.Second);
            Console.WriteLine(" 11) Ticks: " + d20.Ticks);
            Console.WriteLine(" 12) TimeofDay: " + d20.TimeOfDay);
            Console.WriteLine(" 3) Year: " + d20.Year);

            // Definindo formatos para apresentar a data

            Console.WriteLine(d20.ToLongDateString());
            Console.WriteLine(d20.ToLongTimeString());
            Console.WriteLine(d20.ToShortDateString());
            Console.WriteLine(d20.ToShortTimeString());
            Console.WriteLine(d20.ToString());

            // formando a data manualmente 

            Console.WriteLine(d20.ToString("yyyy-MM-dd HH:mm:ss"));

            // imprimindo com os milleseconds
            Console.WriteLine(d20.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            // Fazendo operações com data e hora


            DateTime d21 = d20.AddHours(2);
            Console.WriteLine(d21);

            DateTime d23 = d20.AddMinutes(3);
            Console.WriteLine(d23);

            DateTime d24 = DateTime.Now;

            DateTime d25 = d24.AddDays(7);

            Console.WriteLine("Data geração do boelto" +  d24);
            Console.WriteLine("Data vencimento do boelto" + d25);


            */

            //### TIMESSPAN - INTERVALOS DE DURAÇÃO DE TEMPO.

            /*
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            TimeSpan t2 = new TimeSpan(9000000L);

            TimeSpan t3 = new TimeSpan(2, 11, 21);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2,11, 21, 300);


            Console.WriteLine( t1);

            Console.WriteLine(t1.Ticks);


            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);


            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t8);

            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t10);
            */


            // Operações com Timespan

            /*  

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            //

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine("Days: " +t4.Days);
            Console.WriteLine("Hour: " + t4.Hours);
            Console.WriteLine("Minutes: " + t4.Minutes);
            Console.WriteLine("Seconds: " + t4.Seconds);
            Console.WriteLine("Milleseonds " + t4.Milliseconds);
            Console.WriteLine("Ticks: " + t4.Ticks);


            Console.WriteLine("TotalDays: " + t4.TotalDays);
            Console.WriteLine("TotalHours: " + t4.TotalHours);
            Console.WriteLine("TotalMinutes " + t4.Minutes);
            Console.WriteLine("TotalSeconds " + t4.TotalSeconds);
            Console.WriteLine("TotalMilleseconds " + t4.TotalMilliseconds);

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);


            TimeSpan soma = t5.Add(t6);
            TimeSpan dif = t5.Subtract(t6);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);



            Console.WriteLine(soma);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);


            // trabalho com o DateTimeKind 

            DateTime d1 = new DateTime(200, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(200,8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(200, 8, 15, 13, 5, 58);


            Console.WriteLine("d1 " + d1);
            Console.WriteLine("d1 Kind " + d1.Kind);
            Console.WriteLine("d1 to Local " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc " + d1.ToUniversalTime());

            Console.WriteLine("d2 " + d2);
            Console.WriteLine("d2 Kind " + d2.Kind);
            Console.WriteLine("d2 to Local " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc " + d2.ToUniversalTime());

            Console.WriteLine("d3 " + d3);
            Console.WriteLine("d3 Kind " + d3.Kind);
            Console.WriteLine("d3 to Local " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc " + d3.ToUniversalTime());


            // DateTimeKind padrão 8601


            DateTime d31 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d32 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d31: " + d31);
            Console.WriteLine("d31 Kind: " + d31.Kind);
            Console.WriteLine("d31 to Local: " + d31.ToLocalTime());
            Console.WriteLine("d31 to UTC: " + d31.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d32: " + d32);
            Console.WriteLine("d32 Kind: " + d32.Kind);
            Console.WriteLine("d32 to Local: " + d32.ToLocalTime());
            Console.WriteLine("d32 to UTC: " + d32.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d32.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuido o correto é no forma to abaixo primeiro converta para o formato universal
            Console.WriteLine(d32.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));


            */







            //====>>>>FIM  7777777<<<<====################# TIPOS ESPECIAIS C#  PARTE 1   ###############################################
            //###########################################################################################################################

























            // ############################################# INICIO TTIPO ENUM SESSÃO 9   ###############################################

            /* testes com enum 
           
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPyament

            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPyament.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            /*

            // vamos falar um pouco de design 

            /* CATEGORIA DE CLASSES
             * Em um sistema orientado a objetos de modo geral " tudo" é objeto.
             * 
             * Por questões de design tais como organização, flexibilidade, reuso , delegação e etc. 
             * Há várias categorias de classes
             * 
             *
             * Views, Controllers Entities, Service, Repositories
             */

            // COMPOSIÇÃO

            /* É um tipo de associação que permite que um objeto contenha outro
             * 
             * Relação "tem-um" ou "tem-vários"
             * 
             * Vantagens
             * 
             * Organizçaão: divisão de responsabilidades
             * Coesão;
             * Flexibilidade
             * Reuso
             */

            // Nota: embora o símbolo UML para composição (todo-parte) seja o diamane preto neste contexto
            // estamos chamando de composição qualquer associação tipo "tipo-um " e "tipo-vários"



            // ------------------->  INICIO EXERCIO RESOLVIDO SESSÃO 9 <-------------------------------------------------------------


            // recenbendo e armazenando os dados digitados pelo usuários
            Console.WriteLine("Enter departamen's name:");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data");

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level( Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Base Salary ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // declarando e instanciando e repassando os dados para os objetos

            Department dept = new Department(deptName);

            Worker worker = new Worker(name, level, baseSalary, dept);


            // recebendo os dados enviados pelo usuário referente aos contratos


            Console.WriteLine("How many contracts to this worker");

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++)
            {
                Console.WriteLine($"Enter #{i} com os");

                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duration (hours) ");
                int hours = int.Parse(Console.ReadLine());

                // instanciado o objeto HourContract 

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));

            int year = int.Parse(monthAndYear.Substring(3));

            // imprimindo os dados no console

            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(month, year));


















            // ------------------->  FIM  EXERCIO RESOLVIDO SESSÃO 9 <-------------------------------------------------------------




            // ############################################# FIM TTIPO ENUM SESSÃO 9   ###############################################



        }

        // ABAIXO VAMOS CRIAR UMA FUNÇÃO PARA CALCULAR O RAIO, NO ENTANTO NÃO SERÁ NECESSÁRIO UTILIZAR O PUBLIC, POIS A FUNÇÇÃO SERÁ USADA NO PROPRIO MAIN.

        // MAS O STATIC SE FAZ NECESSÁRIO 

        static double Circuferencia(double r)
        {
            return 2.0 * pi * r;
        }

        static double Volume(double r)
        {
            return ((4.0/3.0) *( pi * r * r * r));
        }

    }
}
