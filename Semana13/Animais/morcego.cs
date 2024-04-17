using System;

namespace Animais
{
    public class Morcego : Animal, IMamifero, IVoador
    {
        public int NumeroDeMamilos{get{return 2;}}
        public int NumeroDeAsas{get{return 2;}}
        public override string Som()
        {
            return base.Som() + "Ti Ti Ti";
        } 
        public override string ToString(){
            return "do Morcego";
        }
    }
}