using System;

namespace Animais
{
    public class Cao : Animal, IMamifero
    {
        public int NumeroDeMamilos{get{return 6;}}
        public override string Som()
        {
            return base.Som() + "Au Au Au";
        }
        public override string ToString(){
            return "do Cão";
        }
    }
}