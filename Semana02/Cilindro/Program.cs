using System;

namespace Cilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double altura;
            double raio;
            double volume;
            double superficie;

            Console.WriteLine("Insira a altura do Cilindro: ");
            altura = Convert.ToDouble ( Console.ReadLine() );
            Console.WriteLine("Insira o raio do Cilindro: ");
            raio = Convert.ToDouble ( Console.ReadLine() );

            volume = Math.PI * Math.Pow(raio , 2) * altura;

            Console.WriteLine("Aqui está o resultado do volume: ");
            Console.WriteLine(volume);

            superficie = 2 * Math.PI * raio * (raio + altura);
            Console.WriteLine("E agora a superficie: ");
            Console.WriteLine(superficie);

        }
    }
}