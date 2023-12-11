using System;

namespace Fibonacci
{
    class Program
    {   

        private static int Fibonacci(int n){
            int fib;
            if(n <= 2){
                fib = 1;
            }else{
                fib = Fibonacci(n -2) + Fibonacci(n - 1);
            }
            return fib;
        }

        static void Main(string[] args)
        {   
            int n;
            int fib;




            if(args.Length > 0 ){
                n = Convert.ToInt32(args[0]);
            }else{
                Console.WriteLine("Vou procurar um número na sequência de Fibonacci");
                Console.Write("Indica a posição do número: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            fib = Fibonacci(n);

            Console.WriteLine($"Nº da posição {n} é: {fib}");
            
        }
    }
}
