using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public int Vitoria { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int poder { get; set; }
        public void Lutar(Pet A, Pet B)
        {
            if (A.poder > B.poder)
            {
                Console.WriteLine(A.Nome + " Venceu!");
                A.Vitoria += 1;
            }
            else if (A.poder == B.poder)
            {
                Console.WriteLine("Empatou");
            }
            else
            {
                Console.WriteLine(B.Nome + " Venceu!");
                B.Vitoria += 1;
            }
        }
    }

}
