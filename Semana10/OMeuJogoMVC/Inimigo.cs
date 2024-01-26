using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMeuJogoMVC
{
    public class Inimigo
    {
        private string nome;
	    private int vida;
        private int escudo;

        public Inimigo(string nome){
            this.nome = nome; // nome oculta this.nome
            vida = 100;
            escudo = 100;
        }

        public string GetNome(){
            return nome;
        }

        public int GetVida(){

            /*
            if(vida <= 50){
                vida = 50;
                
            }
            */
            return vida;

        }

        public void SetNome(string novoNome){

            string nomeAux = novoNome.Trim();
            this.nome = novoNome;
        }

        public int GetEscudo(){

            return escudo;
        }

	    public void Abastecer(Abastecimento abast, int au){

            if(abast == Abastecimento.Vida){
                vida += au;
                if(vida > 100){
                    vida = 100;
                }
            }

            if(abast == Abastecimento.Escudo){
                escudo += au;
                if(escudo > 100){
                    escudo = 100;
                }
            }

        }

        public void Danificar(int dano){
	        //vida -= dano;

            escudo -= dano;
            int aux2 = escudo;

            if(escudo <= 0 ){
                vida += aux2;
                escudo = 0;
            }

	        if (vida <= 0){
                vida = 0;
                Console.WriteLine("Morreu");
            } 
        }
    }
}