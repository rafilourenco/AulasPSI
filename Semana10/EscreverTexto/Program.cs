using System;
using System.IO;

namespace EscreverTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int nrint;
            double nrreal;

            

            Console.WriteLine("Introduza o nome do ficheiro que deseja abrir.");
            string resposta = Console.ReadLine();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), resposta);
            TextWriter text1 = File.CreateText(path);

            Console.WriteLine("Introduza um valor para uma string: ");
            text = Console.ReadLine();
            text1.WriteLine(text);
  
            Console.WriteLine("Introduza um valor para um numero inteiro: ");
            nrint = Convert.ToInt32(Console.ReadLine());
            text1.WriteLine(nrint);

            Console.WriteLine("Introduza um valor para um numero real: ");
            nrreal = Convert.ToDouble(Console.ReadLine());
            text1.WriteLine(nrreal);

            text1.Close();



        }
    }
}
