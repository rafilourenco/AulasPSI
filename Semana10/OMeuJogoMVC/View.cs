using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMeuJogoMVC
{
    public class View
    {

        Controller cl;

       public View(Controller ag){
            cl = ag;
       }

        public void ImprimirMSG(string str){
            Console.WriteLine($"{str} dos inimigos");

        }
        public string NomeInimigo(int i){
            Console.WriteLine($"Introduza o nome do inimigo {i + 1}:");
            return Console.ReadLine();
        }

        public void MostrarNome(int i, Inimigo[] arrayInim){
            Console.WriteLine($"Inimigo {i + 1}: {arrayInim[i].GetNome()}");
        }
       

        public void VidaInim(int i, Inimigo[] arrayInim){
            Console.WriteLine($"Vida do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetVida()}");
            Console.WriteLine($"Escudo do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetEscudo()}");
        }

        public void DanoInim(int i, Inimigo[] arrayInim){
            Console.Write($"Escolha o dano que deseja aplicar no inimigo {arrayInim[i].GetNome()}: ");
            int dmg = Convert.ToInt32(Console.ReadLine());
            arrayInim[i].Danificar(dmg);
            Console.WriteLine($"Vida do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetVida()}");
            Console.WriteLine($"Escudo do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetEscudo()}");
        }

        public string PerguntaAbast(){
            Console.WriteLine("Deseja Abastecer os inimigos?(Sim/Não)");
            return Console.ReadLine();
        }

        public int AbastecerVida(int i, Inimigo[] arrayInim){
               
            Console.Write($"Escolha a quantidade que deseja abastecer a vida do inimigo {arrayInim[i].GetNome()}: ");
            return Convert.ToInt32(Console.ReadLine());
      
        }

        public int AbastecerEscudo(int i, Inimigo[] arrayInim){
            Console.Write($"Escolha a quantidade que deseja abastecer o escudo do inimigo {arrayInim[i].GetNome()}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void MostrarAbastecer(int i, Inimigo[] arrayInim){
             Console.WriteLine($"Depois do abastecimento a vida do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetVida()} e o escudo está a: {arrayInim[i].GetEscudo()}");
        }
    }
}
