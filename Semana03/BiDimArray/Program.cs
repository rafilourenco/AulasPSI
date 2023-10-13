using System;

namespace BiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            float[,] array;

            Console.WriteLine("Introduza a dimensão horizontal:");
            x = Convert.ToInt32( Console.ReadLine() );
             Console.WriteLine("Introduza a dimensão vertical:");
            y = Convert.ToInt32( Console.ReadLine() );

            array = new float[x, y];

            for (int i = 0; i < array.GetLength(0); i++){
	            for (int j = 0; j < array.GetLength(1); j++){

                    array[ i,  j ] = i;
		            Console.Write(array[ i,  j ]);
	            }
	            Console.WriteLine();
            }
        }
    }
}
