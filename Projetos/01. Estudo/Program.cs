using System;

namespace MeuApp
{
        class Program
        {
            static void Main(string[] args)
            {

            Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);

            var manutecaoEletrica = new Product(2, " Manutenção Elétrica residencial", 500, EProductType.Service);

            mouse.Id = 55;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);

            int a = 25;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 32;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int valorum = 0;
            
            while(valorum <= 5)
            {
            Console.WriteLine(valorum);
            valorum++;
            }

                var texto = "Testando";
                Console.WriteLine(texto);

                if (25 == 25)
                    Console.WriteLine("É igual");

                Console.WriteLine("Finalizou o Programa");

                string valor = "oie";
                switch (valor)
                {
                    case "tchau": Console.WriteLine("Não"); break;
                    case "amanhã": Console.WriteLine("Não"); break;
                    case "oie": Console.WriteLine("Sim"); break;
                }

                for (var i = 0; i <= 5; i++)
                    Console.WriteLine(i);

                    var valordois = 0;
                do 
                {
                    Console.WriteLine("Teste");
                    valordois ++;
                } while (valordois < 5);

                MeuMetodo();

                string nome = RetornaNome("Patricia", "Novaski");
                Console.WriteLine(nome);

            }

           static void MeuMetodo()
            {
                Console.WriteLine("C# é legal");
            }

            static string RetornaNome(string nome, string sombrenome)
            {
                return nome + " " + sombrenome;

            }

            struct Product 
            {
                public Product(int id, string name, double price, EProductType type)
                {
                    Id = id;
                    Name = name;
                    Price = price;
                }
                public int Id;
                public string Name;
                public double Price;
                public double PriceInDolar(double dolar)
                {
                    return Price * dolar;
                }
            }


            enum EProductType
            {
                Product = 1,
                Service = 2
            }
        }
}
