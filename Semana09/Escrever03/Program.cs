using System;
using System.IO;

namespace Escrever03
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            string s;
            int s2 = 0;
            string resposta;
            bool exceptionthrow = true;

            do
            {
                try{
                    Console.WriteLine("Introduza o nome do ficheiro que deseja abrir.");
                    resposta = Console.ReadLine();
                    exceptionthrow = true;

                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), resposta);

                    StreamReader sr = new StreamReader(path);

                    while((s = sr.ReadLine()) != null){
                        Console.WriteLine(s);
                        count++;
                    }
                    Console.WriteLine($"Número de Linhas: {count}");

                    sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin); 
                    while(s2 != -1){
                        s2 = sr.Read();
                        Console.WriteLine(s2);
                        count2++;
                    }
                    
                    Console.WriteLine($"Número de caractereres: {count2}");
                    
                    sr.Close();
                }

                catch(Exception e){
                    Console.WriteLine("Ocorreu um erro desconhecido.");
                    Console.WriteLine("Problema: " + e.Message);
                    exceptionthrow = true;
                }
                
            }while(exceptionthrow == true);



            
        }
    }
}
    

