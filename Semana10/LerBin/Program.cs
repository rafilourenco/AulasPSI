using System;
using System.IO;
using System.Text;

namespace LerBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o nome do ficheiro que deseja abrir.");
            string resposta = Console.ReadLine();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), resposta);
            BinaryReader text1 = new BinaryReader(File.Open(path, FileMode.Open));


            Console.WriteLine(text1.ReadString());
           
            Console.WriteLine( text1.ReadInt32());
            
            Console.WriteLine(text1.ReadDouble());

            text1.Close();
        }
    }
}
