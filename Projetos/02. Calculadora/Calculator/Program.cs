using System;

namespace Calulator
{
    class Program
    {
        static void Main(string[] args)
        {   

            Menu();
           
        }

        static void Menu()

        {
        
            Console.Clear();

            Console.WriteLine("Qual opração matemática deseja realizar? ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - DIVISÃO");
            Console.WriteLine("4 - MULTIPLICAÇÃO");
            Console.WriteLine("5 - SAIR");

            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res) {
                case 1: Soma(); break; 
                case 2: Subtracao(); break; 
                case 3: Divisao(); break; 
                case 4: Multiplicacao(); break; 
                case 5: System.Environment.Exit(0); break; 
                default: Menu(); break; 

            }

        }

        static void Soma()
        
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                float resultado = v1 + v2;
                Console.WriteLine(" O resultado da soma é: " + resultado);
                Console.WriteLine(" ");

                Console.ReadKey();
                Menu();

        }

        static void Subtracao()
        
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine(" ");

            Console.ReadKey();

            Menu();

        }


        static void Divisao()

        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1 / v2;
            Console.WriteLine($" O resultado da divião é {resultado}");
            Console.ReadKey();

            Menu();

        }

        static void Multiplicacao()

        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1 * v2;
            Console.WriteLine($" O resultado da divião é {resultado}");
            Console.ReadKey();

            Menu();
            

        }



    }
}