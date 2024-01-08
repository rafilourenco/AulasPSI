using System;

namespace TesteErros
{
    class Program
    {
        static void Main(string[] args)
        {   

            try{
                Console.Write("Insere um número inteiro: ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número inserido: {i}");
            }
            catch (Exception e){
                Console.WriteLine("Ocorreu o seguinte problema: " + e.Message);
            }
            

        }
    }
}
