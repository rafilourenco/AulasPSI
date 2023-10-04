using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double dd = 0.12345;
            int ii = 18;

            string pais = "Angola";
            Console.WriteLine(pais);
            string paisUni = "Angola\u00A9";
            Console.WriteLine(paisUni);
            string paisN = "Angola,\ngrande pais";
            Console.WriteLine(paisN);
            string paisverb = @"Angola não tem símbolo de copyright \u00A9";
            Console.WriteLine(paisverb);
            string cont = "Angola" + " é " + "Grande";
            Console.WriteLine(cont);
            int x;
            int y;
            string soma = $"{x = 10} mais {y = 5} é igual a {x + y}";
            Console.WriteLine(soma);
            string s = String.Format("Bom dia {0}, Macacos {1}", "Angola", "Juntos Fortes");
            Console.WriteLine(s);

            string arren = $"x={dd:f2}";
            Console.WriteLine(arren);
            string decimal1 = String.Format($"‘{dd:p1}’");
            Console.WriteLine(decimal1);

            
            
        }
    }
}
