using System;

namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soma = 0;
            Random rnd = new Random();

            Console.WriteLine("Introduza o número de dados a lançar: ");
            n = Convert.ToInt32 (Console.ReadLine());

            
            for (int i = 1; i <= n; i++){
               int aux = rnd.Next(1,6);
               Console.WriteLine($"Valor do dado {i}: {aux}");
               soma += aux;
            }


            Console.WriteLine($"Valor da soma: {soma}");

                
         }
    }
}
