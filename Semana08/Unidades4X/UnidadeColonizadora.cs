using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidades4X
{
    public abstract class UnidadeColonizadora : Unidade
    {
        
        public override float Valor{
            get => 5;
        }
        public UnidadeColonizadora(int movimento, int vida) :base(movimento, vida){
            
        }

        //Método
        public void Colonizar(){
            Console.WriteLine($"A unidade colonizou a casa.");
        } 
    }
}