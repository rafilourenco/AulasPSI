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
        }
    }
}
