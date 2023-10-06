using System;

namespace ValoresEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte sx = sbyte.MaxValue;
            double dx = double.MaxValue;
            int ix = int.MaxValue;

            sbyte sm = sbyte.MinValue;
            double dm = double.MinValue;
            int im = int.MinValue;

            Console.WriteLine("Valores Maximos: ");
            Console.WriteLine(sx);
            Console.WriteLine(dx);
            Console.WriteLine(ix);

            Console.WriteLine("Valores Minimos: ");
            Console.WriteLine(sm);
            Console.WriteLine(dm);
            Console.WriteLine(im);
        }
    }
}