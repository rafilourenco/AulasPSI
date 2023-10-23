using System;

namespace NPCPerks
{
    class Program
    {   
        private static void raca(){



        }
        
        static void Main(string[] args)
        {   
            int nrnpc = 0;
            int aux = 0;
            int traitnpc;
            int aux2;
            string resposta;
            string resposta2;

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
                aux = 1 << i;
                Console.WriteLine((Traits)aux);
            }
            for(int i = 0; i < nrnpc; i++){
                Console.WriteLine($"Escolha a trait para o NPC {i + 1}:");
                for(int j = 0; j < Enum.GetNames(typeof(Traits)).Length;j ++){
                    aux = 1 << j;
                    Console.WriteLine($"{j + 1}. {(Traits)aux}");
                }
                traitnpc = Convert.ToInt32(Console.ReadLine());
                tipotraits[i] |= (Traits)traitnpc;
                Console.WriteLine($"Trait NPC {i + 1}: {tipotraits[i]}");
            }

            for(int i = 0;i < nrnpc; i++){
                Console.WriteLine($"Caracteristicas do NPC {i + 1}");
                Console.Write($"{tiporaca[i]}, ");
                Console.Write($"{tipoclasse[i]}, ");
                Console.WriteLine($"{tipotraits[i]}.");
            }


            Console.WriteLine("Deseja adicionar mais traits?");
            Console.WriteLine("Responda com Sim ou Não");
            resposta = Console.ReadLine();

            if(resposta == "Sim" || resposta == "sim"){
                for(int i = 0; i < nrnpc;i++){
                    Console.WriteLine($"Escolha outra trait para o NPC {i + 1}:");
                    for(int j = 0; j < Enum.GetNames(typeof(Traits)).Length;j++){
                        aux = 1 << j;
                        Console.WriteLine((Traits)aux);                 
                    }
                    for(int h = 0; h < nrnpc;h++){
                        traitnpc = Convert.ToInt32(Console.ReadLine());
                        tipotraits[i] |= (Traits)traitnpc;
                        Console.WriteLine($"Trait NPC {i + 1}: {tipotraits[i]}");
                        Console.WriteLine("Deseja adicionar mais outra trait?(Max:3)");
                        resposta2 = Console.ReadLine();
                        if(resposta2 == "Sim" || resposta2 == "sim"){
                            for(int x = 0; x <nrnpc; x++){
                                Console.WriteLine($"Escolha outra trait para o NPC {i + 1}:");
                                for(int y = 0; y < Enum.GetNames(typeof(Traits)).Length;y++){
                                    aux = 1 << y;
                                    Console.WriteLine((Traits)aux);
                                }
                                for(int k = 0;k < nrnpc;k++){
                                    traitnpc = Convert.ToInt32(Console.ReadLine());
                                    aux2 = 1 << traitnpc - 1;
                                    tipotraits[i] |= (Traits)aux2;
                                    Console.WriteLine($"Trait NPC {i + 1}: {tipotraits[i]}");
                                }                   
                            }
                        }
                    }
                }
                for(int i = 0;i < nrnpc; i++){
                    Console.WriteLine($"Caracteristicas do NPC {i + 1}");
                    Console.Write($"{tiporaca[i]}, ");
                    Console.Write($"{tipoclasse[i]}, ");
                    Console.WriteLine($"{tipotraits[i]}.");
                }    
            }else{
                Console.WriteLine("Que pena!");
            }
            


            Console.ReadKey();
        }
    }
}
