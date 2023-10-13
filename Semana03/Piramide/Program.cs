using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            Console.WriteLine("Introduza um número!");
            resposta = Convert.ToInt32(Console.ReadLine());


            if(resposta > 1){
                for(int i = 1; i <= resposta; i++){
                    for(int x = resposta - i; x > 0;x--){
                        Console.Write(" ");
                    }
                    for(int y = i * 2 - 1; y > 0;y--){
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }else{
                Console.WriteLine("Tem de introduzir um número maior que 1!");
            }
            
        }
    }
}
