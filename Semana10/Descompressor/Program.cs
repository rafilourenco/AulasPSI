using System;
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
            bool exceptionthrow = true;

            do{
                try{

                    Console.WriteLine("Deseja comprimir ou descomprimir um ficheiro?");
                    Console.WriteLine("Pressione 1 para comprimir e 2 para descomprimir:");
                    resposta = Convert.ToInt32(Console.ReadLine());
                    exceptionthrow = false;
                }
                catch(Exception e){
                    Console.WriteLine("Ocorreu um erro desconhecido.");
                    Console.WriteLine("Problema: " + e.Message);
                    exceptionthrow = true;
                }
            }while(exceptionthrow == true);
            

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

            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)){
                using(GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal)){
                    using(StreamWriter sw = new StreamWriter(gzs)){
                        while ((line = Console.ReadLine()).Length > 0){
                            sw.WriteLine(line);
                        }
                    }
                }
            }          
            Console.WriteLine("Compressão Feita.");


        }
        
        
        static void Descomprime(string path, string path2){
            string line;
            using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)){
                using(GZipStream gzs = new GZipStream(fs, CompressionMode.Decompress)){
                        using(StreamReader sr = new StreamReader(gzs))
                        using(StreamWriter sw = new StreamWriter(path2)){
                            while ((line = sr.ReadLine()) != null){
                                sw.WriteLine(line);
                                Console.WriteLine(line);
                            }
                        }

                }
            }
            Console.WriteLine("Descompressão Feita.");

        }
    }
}
