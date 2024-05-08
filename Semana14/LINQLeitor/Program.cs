using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LINQLeitor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array =File.ReadAllLines(args[0]);

            // int aux1 = array.Where(A =>A.Length > 30).Count();
            // int nrlinha = array.Count(linha =>linha.Length > 30);

            int nrlinha =
                (from linha in array
                where linha.Length > 30
                select linha).Count();
            Console.WriteLine(nrlinha);

            // double mediaL = array.Average(linha => linha.Length);
            double mediaL =
                (from linha in array
                select linha.Length).Average();
            Console.WriteLine(mediaL);
   
            // bool linha120 = array.Any(linha => linha.Length > 50);
            bool linha120 =
                (from linha in array
                where linha.Length > 50
                select linha).Any();
            Console.WriteLine(linha120);

            // IEnumerable<string> arrayfiltrado = array.Where(linha => linha.Contains('x')).Select(linha => linha.Trim(' ').Split()[0]);
            IEnumerable<string> arrayfiltrado = 
                from linha in array
                where linha.Contains('X')
                select linha.Trim(' ').Split()[0];


            foreach(string linha in arrayfiltrado){
                Console.WriteLine(linha);
            }


        }
    }
}
