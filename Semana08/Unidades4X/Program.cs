using System;

namespace Unidades4X
{
    class Program
    {
        static void Main(string[] args)
        {
            Unidade unidade1 = new UnidadeMilitar(10, 100, 20);
            Unidade unidade2 = new UnidadeMilitar(10,150,50);

            unidade1.Mover();
            unidade2.Mover();

            Console.Write("Vida e valor da Unidade 1: ");
            Console.WriteLine($"{unidade1.Vida}, {unidade1.Valor}");

            Console.Write("Vida e valor da Unidade 2: ");
            Console.WriteLine($"{unidade2.Vida}, {unidade2.Valor}");


        }
    }
}
