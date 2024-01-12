﻿using System;
using System.IO;
using System.IO.Compression;



namespace Descompressor
{
    class Program
    {
        static void Main(string[] args)
        {   
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ficheiro.txt.gz");
            string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ficheiro.txt");

            int resposta = 0;
            Console.WriteLine("Deseja comprimir ou descomprimir um ficheiro?");
            Console.WriteLine("Pressione 1 para comprimir e 2 para descomprimir:");
            resposta = Convert.ToInt32(Console.ReadLine());

            if(resposta == 1){
                Console.WriteLine("Escolheu comprimir!");
                Comprime(path);
            }else if(resposta == 2){
                Console.WriteLine("Escolheu Descomprimir!");
                Descomprime(path, path2);
            }else{
                Console.WriteLine("Escolheu uma opção invalida!");
            }


        }

        static void Comprime(string path){
            string line;

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);

            StreamWriter sw = new StreamWriter(gzs);

            while ((line = Console.ReadLine()).Length > 0){
                sw.WriteLine(line);
            }
            Console.WriteLine("Compressão Feita.");
            sw.Close();


        }
        
        
        static void Descomprime(string path, string path2){
            string line;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);


            GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress);

            StreamWriter sw = new StreamWriter(path2);
            StreamReader sr = new StreamReader(gzs);

            
            while ((line = sr.ReadLine()) != null){
                sw.WriteLine(line);
                Console.WriteLine(line);
            }
            
            
            Console.WriteLine("Descompressão Feita.");
            sw.Close();
        }
    }
}
