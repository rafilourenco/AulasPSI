using System;
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
            string[] inputs = new string[10];


            Console.WriteLine("Pronto para escrever: ");
            do{
                
                input = Console.ReadLine();
                if(input != ""){
                    inputs[i] = input;
                }

                i++;
            }while(input != "");

            File.WriteAllLines(path, inputs);
        }
    }
}
