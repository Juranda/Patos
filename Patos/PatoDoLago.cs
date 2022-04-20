using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patos
{
    public class PatoDoLago : Pato
    {
        IQuack quack = new DiferenciadoQuack();
        IVoa voa = new NormalVoo();
        ICome come = new NormalCome();
    }
}