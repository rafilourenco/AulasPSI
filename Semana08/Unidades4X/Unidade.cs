using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidades4X
{
    public abstract class Unidade   
    {


        private int movimento;
        public virtual int Vida{get;set;}
        public abstract float Valor{get;}


        public Unidade(int movimento, int vida){
            Vida = vida;
            this.movimento = movimento;
        }


        //Método
        public void Mover(){
            Console.WriteLine($"A Unidade moveu {movimento} casas.");
        }

        



    }
}