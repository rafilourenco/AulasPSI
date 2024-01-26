using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMeuJogoMVC
{
    public class Controller
    {
        private Inimigo[] arrayInim;

        public Controller(Inimigo[] al){
            arrayInim = al;
        }

        public void Iniciar(View vw){
            vw.ImprimirMSG("Nome");
            for(int i=0;i < arrayInim.Length;i++){
                Inimigo s = new Inimigo(vw.NomeInimigo(i));
                arrayInim[i] = s;
            }

            for(int i=0;i < arrayInim.Length;i++){
                vw.MostrarNome(i, arrayInim);
                vw.VidaInim(i, arrayInim);
            }

            for(int i=0;i < arrayInim.Length;i++){
                vw.DanoInim(i, arrayInim);
            }

            for(int i=0;i < arrayInim.Length;i++){
                string aux = vw.PerguntaAbast();
                if(aux == "sim" || aux == "Sim"){
                    arrayInim[i].Abastecer(Abastecimento.Vida, vw.AbastecerVida(i, arrayInim));
                    
                    arrayInim[i].Abastecer(Abastecimento.Escudo, vw.AbastecerEscudo(i, arrayInim));
                }
                vw.MostrarAbastecer(i, arrayInim);
            }



        }



        


    }
}