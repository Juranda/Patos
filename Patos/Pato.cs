using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patos
{
    public class Pato
    {
        IQuack quack = new NormalQuack();
        IVoa voa = new NormalVoo();
        ICome come = new NormalCome();

        virtual public void Quack(){
            this.quack.Quack();
        }
        virtual public void Voar(){
            this.voa.Voar();
        }
        virtual public void Comer(){
            this.come.Comer();
        }

        public void MudarQuack(IQuack quackNovo){
            quack = quackNovo;
        }
        public void MudarVoo(IVoa vooNovo){
            voa = vooNovo;
        }
        public void MudarComer(ICome comeNovo){
            come = comeNovo;
        }



    }
}