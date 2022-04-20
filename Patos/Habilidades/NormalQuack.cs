using System;

namespace Patos
{
    public class NormalQuack : IQuack
    {
        public void Quack(){
            Console.WriteLine("Quack!");
        }
    }
}