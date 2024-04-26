using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorAnimais
{
    public class Animal : IComparable <Animal>
    {
        public string Nome{get;}
        public int Peso{get;set;}

        public Animal(string nome,int peso){
            Nome = nome;
            Peso = peso;
        }



        public int CompareTo(Animal other){

            if(other == null) return 1;
            return this.Peso -other.Peso;
        }        
    }

}