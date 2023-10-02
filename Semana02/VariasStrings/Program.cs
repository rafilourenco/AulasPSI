using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string pais = "Angola";
            Console.WriteLine(pais);
            string paisUni = "Angola\u00A9";
            Console.WriteLine(paisUni);
        }
    }
}
