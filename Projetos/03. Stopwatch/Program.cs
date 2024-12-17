using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(String[] args)
        {   
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 Segundos");
            Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");

            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1, 1)); //Pegando o último caracter da string

            Console.WriteLine(data);


        }

        static void Start(int time)
        {
            
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado");
            Thread.Sleep(2500);

        }

    }
}