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

        static void Main(string[] args)
        {
            // ContarAte10();
            /*
            int variavel;
            Console.Write("Defina o valor da variavel int: ");
            variavel = Convert.ToInt32( Console.ReadLine());
            ContarAteN(variavel);
            */

            double base1;
            double expoente;
            double resultado = 1;

            Console.WriteLine("Introduza dois números reais.");

            Console.WriteLine("Introduza o primeiro número: ");
            base1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduza o segundo número: ");
            expoente = Convert.ToDouble(Console.ReadLine());

            for(int i = 1; i<= expoente;i++){
                resultado *= base1;
            }

            Console.WriteLine(resultado);
        }
    }    
}
