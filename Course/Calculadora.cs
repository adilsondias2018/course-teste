
using System;

namespace Course
{
    class Calculadora
    {   // como para calculadora independente do objeto ser calc1 ou calc2  o resultado não muda pois o valor de pI permanence o mesmo 
        // asim como as operação por isso é que utilizamos o static;
        // QUANDO UTILIZAMOS O STATIC NA CLASSE NÃO É NECESSÁRIO INSTARIAR O OBJETO NO PROGRAMA PRINCIPAL.

        public static double Pi = 3.14;
        public static double IOF = 6.0;

        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return ((4.0 / 3.0) * (Pi * r * r * r));
        }

        public static double ConversorDolar(double valorDolar, double quantidadedolar)
        {
            double total = valorDolar * quantidadedolar;
            return total + ((total * IOF) / 100.0);


        }

        // Aqui vamos trabalhar como MODIFICADORES DE PARAMETROS 

        /* Em qual momento esse processo se faz necessário, as vezes queremos somar algumas valores e esses valores variam de acordo 
         * com a necessidade as vezes queremos a soma de dois números, as três e asssim por diante
         * Poderiamos fazer um construtor e depois sobrecarga para somar duas ou três opções de soma tipo com 2 3 5 assim por diante.
         * Porém caso não tenha um construtor par uma das somas desejadas teria-mos problemas. ENTÃO COMO RESOLVER ISSO!?
         * 
         * Para isso temos os MODIFICADORES DE PARAMETROS 
         * 
         * 
         * 
         */

        // ABAIXO TEMOS UM EXEMPLO MAIS VERBOSO
        public static int Sum (int[] numbers) // PERCEBA QUE RECEBEMOS UM VETOR COMO PARAMETRO E QUEREMSO EFETUAR A SOMA DO MESMO ESSES VETROES PODEM SEREM VARIADOS COM NO MAIN.
        {
            int sum = 0;
            
            for( int i= 0; i< numbers.Length; i++)
            {
                sum += numbers[i];

            }

            return sum;
        }

        // VEJA QUE O METODOS PARAMS A COISA FICA MAIS FÁCIL 

        public static int Soma(params  int[] numbers) // perceba que a única modificação foi a palavra params no início 
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

            }

            return sum;
        }

        // trabalhando com o modificador de parametros ref

        public static void Triple (ref int x)
        {
            x = x * 3;
        }


        // trabalhando com o modificador de parametros out

        public static void Triple( int origin , out int result)
        {
            result = origin * 3; 
        }


    }
}




