using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patos
{
    public class NormalVoo : IVoa
    {
        public void Voar(){
            Console.WriteLine("Voo");
        }
    }
}