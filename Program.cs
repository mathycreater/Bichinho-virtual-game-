using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            bool A = false;
            Pet Pet1 = new Pet();
            Pet Pet2 = new Pet();

            Console.WriteLine("Digite o nome do primeiro pet: ");
            Pet1.Nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do segundo pet: ");
            Pet2.Nome = Console.ReadLine();

            while  (A == false)

            {
                Console.WriteLine("Digite a força do primeiro Pet: ");
                Pet1.poder = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do seu segundo Pet: ");
                Pet2.poder = int.Parse(Console.ReadLine());

                Pet1.Lutar(Pet1, Pet2);

                Console.WriteLine("Quantidade de vitórias de " + Pet1.Nome + ": " + Pet1.Vitoria);
                Console.WriteLine("Quantidade de vitórias de " + Pet2.Nome + ": " + Pet2.Vitoria);

            }
        }
    }
}
