using System;

namespace Animais
{
    public class Gato : Animal, IMamifero
    {
        public int NumeroDeMamilos{get{return 4;}}
        public override string Som()
        {
            return base.Som() + "Miau";
        }
        public override string ToString(){
            return "do Gato";
        }
    }
}