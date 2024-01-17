using System;
using System.IO;
using System.Text;

namespace EscreverBin
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
            BinaryWriter text1 = new BinaryWriter(File.Open(path, FileMode.Create));

            Console.WriteLine("Introduza um valor para uma string: ");
            text = Console.ReadLine();
            text1.Write(text);
  
            Console.WriteLine("Introduza um valor para um numero inteiro: ");
            nrint = Convert.ToInt32(Console.ReadLine());
            text1.Write(nrint);

            Console.WriteLine("Introduza um valor para um numero real: ");
            nrreal = Convert.ToDouble(Console.ReadLine());
            text1.Write(nrreal);

            text1.Close();
        }
    }
}
