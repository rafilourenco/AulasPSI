using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidades4X
{
    public class UnidadeMilitar : Unidade
    {

        
        public int PoderAtaque{get;set;}
        public int XP{get;set;}
        public override int Vida{
            get=> base.Vida + XP;
        }
        public override float Valor{
            get => PoderAtaque + XP;
        }
        

        public UnidadeMilitar(int movimento, int vida, int poderAtaque) : base(movimento,vida){
	        PoderAtaque = poderAtaque;
	        XP = 0;
        }

        

        //Método
        public void Atacar(UnidadeMilitar x){
            Console.WriteLine($"A Unidade atacou a unidade {x} e deu de dano.");
        }
    }
}