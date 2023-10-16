using System;
using System.Runtime.InteropServices;

namespace BiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            float total = 0;
            float[] media;
            float[,] array;

            Console.WriteLine("Introduza a dimensão horizontal:");
            x = Convert.ToInt32( Console.ReadLine() );
             Console.WriteLine("Introduza a dimensão vertical:");
            y = Convert.ToInt32( Console.ReadLine() );

            array = new float[x, y]; // Inicializar o array
            media = new float[x];

            for (int i = 0; i < array.GetLength(0); i++){ // Percorrer dimensão horizontal do array
	            for (int j = 0; j < array.GetLength(1); j++){ // Percorrer dimensão vertical do array
 
                    Console.Write($"Valor de {i}, {j}:");
                    array[i, j] = Convert.ToSingle ( Console.ReadLine());

                    total += array[i, j];
	            }
	            Console.WriteLine();

                media[i] = total /x;

                total = 0;
            }

            

            for(int i = 0; i < media.Length; i++){
                Console.WriteLine($"Média da linha {i}: {media[i]}");
                total += media[i];
            }
            
            Console.WriteLine($"Soma de todas as médias: {total}");
        }
    }
}
