using System;

namespace PrimeiroMetodo
{
    class Program
    {
        
        private static void ContarAteN(int variavel){
            
            Console.WriteLine("Valores de int: ");
            for(int i = 1;i <= variavel;i++){
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        private static void ContarAte10(){


            for(int i = 1;i <=10;i++){
                Console.WriteLine(i);
            }
            Console.WriteLine();

        }

        private static void Main(string[] args)
        {
            // ContarAte10();
            int variavel;
            Console.Write("Defina o valor da variavel int: ");
            variavel = Convert.ToInt32( Console.ReadLine());
            ContarAteN(variavel);
        }
    }
}
