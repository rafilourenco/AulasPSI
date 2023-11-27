using System;

namespace OMeuJogo
{
    class Program
    {
        static void Main(string[] args)
        {

            int quant;
            Inimigo soldado = new Inimigo("Soldado");
            Inimigo[] arrayInim;
            int dmg;
            int heal;
            int healshield;
            string resposta;

            Console.WriteLine("Introduza a quantidade de inimigos: ");
            quant = Convert.ToInt32(Console.ReadLine());
            arrayInim = new Inimigo[quant];



            Console.WriteLine("Introduza o nome dos inimigos!");
            for(int i = 0; i < quant; i++){
                Console.WriteLine($"Introduza o nome do inimigo {i + 1}:");
                string aux;
                aux= Console.ReadLine();
                Inimigo s = new Inimigo(aux);
                arrayInim[i] = s;
            }

            Console.WriteLine("Nome dos inimigos: ");
            for(int i = 0; i <quant; i++){
                Console.WriteLine($"Inimigo {i + 1}: {arrayInim[i].GetNome()}");
            }


            for(int i = 0; i < quant;i++){
                Console.WriteLine($"Vida do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetVida()}");
            }

            for(int i = 0; i < quant;i++){
                Console.Write($"Escolha o dano que deseja aplicar no inimigo {arrayInim[i].GetNome()}: ");
                dmg = Convert.ToInt32(Console.ReadLine());
                arrayInim[i].Danificar(dmg);
            }
            
            Console.WriteLine("Vida dos inimigos após serem danificados: ");
            for(int i = 0; i < quant;i++){
                Console.WriteLine($"Vida do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetVida()}");
            }
            Console.WriteLine("\n");

            
            Console.WriteLine("Deseja Abastecer os inimigos?(Sim/Não)");
            resposta = Console.ReadLine();
            if(resposta == "Sim" || resposta == "sim"){
                for(int i = 0; i < quant;i++){
                Console.Write($"Escolha a quantidade que deseja abastecer a vida do inimigo {arrayInim[i].GetNome()}: ");
                heal = Convert.ToInt32(Console.ReadLine());
                arrayInim[i].Abastecer(Abastecimento.Vida, heal);
                }
                for(int i = 0; i < quant;i++){
                Console.Write($"Escolha a quantidade que deseja abastecer o escudo do inimigo {arrayInim[i].GetNome()}: ");
                healshield = Convert.ToInt32(Console.ReadLine());
                arrayInim[i].Abastecer(Abastecimento.Escudo, healshield);
                }
            }
            Console.WriteLine("\n");

            for(int i = 0; i < quant;i++){
                Console.WriteLine($"Depois do abastecimento a vida do inimigo {arrayInim[i].GetNome()}: {arrayInim[i].GetVida()} e o escudo está a: {arrayInim[i].GetEscudo()}");
            }


            

        }
    }
}
