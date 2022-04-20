using System;
using Patos;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "Hello Word";
            resposta = resposta.Replace(" ",string.Empty).ToUpper();
            Console.WriteLine(resposta);
        }
    }
}
