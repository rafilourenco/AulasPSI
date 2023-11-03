using System;

namespace ValorEReferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;

            int[] array1 = new int[] {1,2,3};
            int[] array2 = array1;

            
            
            for(int i = 0; i < array1.Length;i++){
                Console.WriteLine(array1[i]);
            }
            array1[1] = a;
            Console.WriteLine(" ");
            for(int i = 0; i < array2.Length;i++){
                Console.WriteLine(array2[i]);
            }
            array2 = new int[] {6,7,8};
            Console.WriteLine(" ");
            for(int i = 0; i < array1.Length;i++){
                Console.WriteLine(array1[i]);
            }

        }
    }
}