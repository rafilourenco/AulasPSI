using System;
using System.IO;

namespace Escrever02
{
    class Program
    {
        static void Main(string[] args)
        {   
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ficheiro.txt");

            StreamWriter sw = new StreamWriter(path);
            Console.WriteLine("Pronto para escrever: ");
            do{
                sw.WriteLine(Console.ReadLine());
            }while(Console.ReadLine() != "");
            sw.Close();
        }
    }
}
