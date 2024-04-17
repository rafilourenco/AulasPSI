using System;

namespace Animais
{
    public class Abelha : Animal, IVoador
    {
        public int NumeroDeAsas{get{return 4;}}
        public override string Som()
        {
            return base.Som() + "Bzz Bzz Bzz";
        }
        public override string ToString(){
            return "da Abelha";
        }
    }
}