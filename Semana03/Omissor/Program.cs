using System;

namespace Omissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char letra;

            Console.WriteLine("Introduza uma frase!");
            frase = Console.ReadLine();

            Console.WriteLine("Agora introduza uma letra para omitir!");
            letra = Convert.ToChar(Console.ReadLine() );

            foreach (char c in frase){ 
                if(c != letra){
                    Console.Write(c);
                }
                
            }
        }
    }
}
