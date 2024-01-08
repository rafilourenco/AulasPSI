using System;

namespace TesteErros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um número inteiro: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Número inserido: {i}");

        }
    }
}
