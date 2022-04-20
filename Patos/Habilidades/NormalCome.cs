using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patos
{
    public class NormalCome : ICome
    {
        public void Comer(){
            Console.WriteLine("Comendo");
        }
    }
}