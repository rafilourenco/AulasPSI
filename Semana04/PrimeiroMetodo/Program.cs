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

        private static void ContarAteN(int n1, int n2){


                for(int i = n1; i <= n2;i++){
                    Console.WriteLine(i);
                }
        }

        static void Main(string[] args)
        {
            // ContarAte10();

            int variavel;
            string resposta;

            Console.WriteLine("Deseja introduzir 1 número, ou 2?");
            resposta = Console.ReadLine();

            if(resposta == "1"){
                ContarAteN(5);
            }else if(resposta == "2"){
                Console.Write("Defina o valor da variavel int 1: ");
                int n1 = Convert.ToInt32( Console.ReadLine());
                Console.Write("Defina o valor da variavel int 2: ");
                int n2 = Convert.ToInt32( Console.ReadLine());
                ContarAteN(n1,n2);
            }else{
                Console.WriteLine("Apenas pode escolher 1 ou 2!");
            }

            
        }
    }    
}
