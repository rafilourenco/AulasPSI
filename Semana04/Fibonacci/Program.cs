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

            Console.WriteLine(Fibonacci(9));
        }
    }
}
