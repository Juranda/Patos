using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patos
{
    public class PatoDaMontanha : Pato
    {
        IQuack quack = new NormalQuack();
        IVoa voa = new DiferenciadoVoo();
        ICome come = new NormalCome();
    }
}