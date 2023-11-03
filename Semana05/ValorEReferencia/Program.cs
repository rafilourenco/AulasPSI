using System;

namespace ValorEReferencia
{
    internal class Program
    {   

        private static void Metodo(int valor, int[] referencia){

            Console.WriteLine(" ");
            Console.WriteLine(valor);
            Console.WriteLine(" ");
            
            Console.Write("[");
            for(int i = 0; i < referencia.Length;i++){
                
                Console.Write(referencia[i]);
                
            }
            Console.Write("]");
            Console.WriteLine(" ");
        }
        
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;

            int[] array1 = new int[] {1,2,3};
            int[] array2 = array1;

            
            
            Metodo(a, array1);
            array1[1] = a;
            Metodo(a, array2);
            array2 = new int[] {6,7,8};
            Metodo(a, array1);

        }
    }
}