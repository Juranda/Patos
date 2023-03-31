using System;
using Patos;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PatoDaMontanha pato = new PatoDaMontanha();

            pato.Quack();
            pato.Voar();


            pato.MudarQuack(new DiferenciadoQuack());
            pato.MudarVoo(new NormalVoo());

            Console.ReadLine();
        }
    }
}
