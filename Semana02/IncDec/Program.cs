using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 5;
            int b = 5;

            a++;
            --b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            */

            int i1 = 7;
            int i2 = 5;
            int i3 = -9;
            int x = 2;

            //x = i1 - i3;
            //x = i3 / i1;
            //x += i2;
            //x *= i1;
            //x %= i2 - 0b1001;
            //7x = i1 << 2;
            x &= 0x000A ^ i1;

            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}
