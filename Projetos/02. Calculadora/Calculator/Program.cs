using System;

namespace Calulator
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.Clear();
            Soma();
            Subtracao();
           
        }

        static void Soma()
        {

            Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                float resultado = v1 + v2;
                Console.WriteLine(" O resultado da soma é: " + resultado);
                Console.WriteLine(" ");

                Console.ReadKey();

        }

        static void Subtracao()
        
        {

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine(" ");

            Console.ReadKey();

        }
    }
}