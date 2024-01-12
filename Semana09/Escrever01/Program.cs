using System;
using System.Collections.Generic;
using System.IO;

namespace Escrever01
{
    class Program
    {
        static void Main(string[] args)
        {   
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ficheiro.txt");
            int i = 0;
            string input;
            List<string> inputs = new List<string>();


            Console.WriteLine("Pronto para escrever: ");
            do{
                
                input = Console.ReadLine();
                if(input != ""){
                    inputs.Add(input);
                }

                i++;
            }while(input != "");

            File.WriteAllLines(path, inputs);
        }
    }
}
