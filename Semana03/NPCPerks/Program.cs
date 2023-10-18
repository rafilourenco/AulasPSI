using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {   
            int nrnpc = 0;

            Raca[] tiporaca;
            Classe[] tipoclasse;
            Traits[] tipotraits;

            Console.WriteLine("Introduza o número de NPC's.");
            nrnpc = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Boa temos {nrnpc} NPC's!");

            tiporaca = new Raca[nrnpc];
            tipoclasse = new Classe[nrnpc];
            tipotraits = new Traits[nrnpc];

            Console.WriteLine("As Raças são: ");
            for(int i = 0; i < Enum.GetNames(typeof(Raca)).Length;i++){
                Console.WriteLine((Raca)i);
            }

            for(int i = 0; i < nrnpc; i++){
                Console.WriteLine($"Escolha a raça para o NPC {i + 1}:");
                for(int j = 0; j < Enum.GetNames(typeof(Raca)).Length;j ++){
                    Console.WriteLine($"{j + 1}. {(Raca)j}");
                }
                int racanpc = Convert.ToInt32(Console.ReadLine()) - 1;
                tiporaca[i] = (Raca)racanpc;
                Console.WriteLine($"Raça NPC {i + 1}: {tiporaca[i]}");
            }
            
            Console.WriteLine("As Classes são: ");
            for(int i = 0; i < Enum.GetNames(typeof(Classe)).Length;i++){
                Console.WriteLine((Classe)i);
            }

            for(int i = 0; i < nrnpc; i++){
                Console.WriteLine($"Escolha a classe para o NPC {i + 1}:");
                for(int j = 0; j < Enum.GetNames(typeof(Classe)).Length;j ++){
                    Console.WriteLine($"{j + 1}. {(Classe)j}");
                }
                int classenpc = Convert.ToInt32(Console.ReadLine()) - 1;
                tipoclasse[i] = (Classe)classenpc;
                Console.WriteLine($"Classe NPC {i + 1}: {tipoclasse[i]}");
            }

            Console.WriteLine("As Traits são: ");
            for(int i = 0; i < Enum.GetNames(typeof(Traits)).Length;i++){
                Console.WriteLine((Traits)i);
            }
            for(int i = 0; i < nrnpc; i++){
                Console.WriteLine($"Escolha a trait para o NPC {i + 1}:");
                for(int j = 0; j < Enum.GetNames(typeof(Traits)).Length;j ++){
                    Console.WriteLine($"{j + 1}. {(Traits)j}");
                }
                int traitnpc = Convert.ToInt32(Console.ReadLine()) - 1;
                tipotraits[i] = (Traits)traitnpc;
                Console.WriteLine($"Trait NPC {i + 1}: {tipotraits[i]}");
            }

            for(int i = 0;i < nrnpc; i++){
                Console.WriteLine($"Caracteristicas do NPC {i + 1}");
                Console.Write($"{tiporaca[i]}, ");
                Console.Write($"{tipoclasse[i]}, ");
                Console.WriteLine($"{tipotraits[i]}.");
            }

            Console.ReadKey();
        }
    }
}
