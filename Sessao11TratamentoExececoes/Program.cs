using System;
using Sessao11TratamentoExececoes.Entities;
using Sessao11TratamentoExececoes.Entities.Exceptions;

namespace Sessao11TratamentoExececoes
{
    /* Exeções 
     * 
     * Uma exeção é qualquer condição de erro ou comportemento inesperado encontrado por um programa em execução
     * 
     * No .NET, uma exceção é um objeto herdado da classe System.Exception
     * 
     *Quano lançada, uma execeção é propagada na piha de chamdas de métodos em execução, até que seja capturada(tratada) ou o program seja encerrado.
     * 
     * ####>> Vantagens:
     * 
     * Delega a lógica do erro para a classe / método responsável pro conhecer as regas que podem ocasionar o erro.
     * 
     * Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes
     * 
     * A exceção pode carregar dados quaisquer
     * 
     * Estrutura try-cath
     * 
     * ---> Bloco try
     * Contém o código que representa a execução normal do treco de código que pode accarretar em um execeção
     * 
     * 
     * ---> Bloco Catch (Caputurar) 
     * Contém o código a ser executado caso  uma exceção ocorra
     * Deve ser especificado o tipo da exceção a ser tratada ( Upcasting é permitido)
     * 
     * --> Bloco Finaly, esse sempre será executado independente da exceção encontrada. 
     * 
     */

    class Program
    {


        static void Main(string[] args)
        {

            // Coocando primeira teoria em prática
            /*
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resul = n1 / n2;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Tentativa de dividir por zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Não é possível utilizar caracteres na divisão");
            }
            finally // 
            {
                Console.WriteLine("O finaly sempre será executado independente do erro e exceção encontroado.");
            }
            ##### fim da primeira teoria 

            */

            // Inicio exercícios Resolvidos

            try
            {
                Console.WriteLine("Room Number");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Check-in data (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-Out data (dd/MM/yy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine("Reservation" + reservation);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Enter data to update the reservation:");

                Console.WriteLine("Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-Out data (dd/MM/yy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);


                Console.WriteLine("Reservation : " + reservation);

            }
            catch (DomainExceptions e)
            {
                Console.WriteLine( "Error Reservation: " +   e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format erro:" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error:" + e.Message);
            }
                       
        }
    }
 

