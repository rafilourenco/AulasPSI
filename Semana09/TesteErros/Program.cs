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
            catch(FormatException f){
                Console.WriteLine("Não foi inserido um número inteiro.");
                Console.WriteLine("Problema: " + f.Message);
            }
            catch(OverflowException o){
                Console.WriteLine("O número inserido é demasiado grande para esta variavel.");
                Console.WriteLine("Problema: " + o.Message);
            }

            catch(Exception e){
                Console.WriteLine("Ocorreu um erro desconhecido.");
                Console.WriteLine("Problema: " + e.Message);
            }
            

        }
    }
}
