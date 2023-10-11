using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            string asterisco = "*";
            Console.WriteLine("Introduza um número!");
            resposta = Convert.ToInt32(Console.ReadLine());


            if(resposta > 1){
                for(int i = 0; i < resposta; i++){
                    for(int x = resposta - i; x>0;x--){
                        Console.Write(" ");
                    }
                    for(int y = 0; y< resposta - i;y++){
                        Console.Write(asterisco);
                    }
                    Console.WriteLine();
                }
            }else{
                Console.WriteLine("Tem de introduzir um número maior que 1!");
            }
            
        }
    }
}
