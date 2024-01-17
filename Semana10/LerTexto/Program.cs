using System;
using System.IO;

namespace LerTexto
{
    class Program
    {
        static void Main(string[] args)
        {   
            string s = "";
            Console.WriteLine("Introduza o nome do ficheiro que deseja abrir.");
            string resposta = Console.ReadLine();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), resposta);
            TextReader text1 =File.OpenText(path);

            while((s = text1.ReadLine())!= null){
                Console.WriteLine(s);
            }

            text1.Close();



        }
    }
}
