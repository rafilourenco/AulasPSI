using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GestorAnimais
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int peso;
            int pesomin;
            string resposta;

            List<Animal> animais = new List<Animal>{new Animal("Gato",6), new Animal("Rato",2)};
            animais.Sort();

            do{
                Console.WriteLine("Introduza o nome do animal:");
                nome = Console.ReadLine();


                if(nome != "sair" && nome != "Sair"){
                    Console.WriteLine("Introduza o peso do animal:");
                    peso = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    animais.Add(new Animal(nome,peso));
                    animais.Sort();
                }
                
            }while(nome != "sair");
            
            Console.WriteLine("Deseja indicar um peso minimo para a lista?");
            resposta = Console.ReadLine();
            Console.WriteLine(" ");

            if(resposta == "Sim" || resposta == "sim"){
                Console.WriteLine("Introduza um peso minimo: ");
                pesomin = Convert.ToInt32(Console.ReadLine());
                IEnumerable<Animal> animaispeso = GetAnimaisComPesoMaiorQue(animais, pesomin);
                foreach(Animal A in animaispeso){
                    Console.WriteLine($"Nome do animal: {A.Nome}");
                    Console.WriteLine($"Peso do animal: {A.Peso}");
                    Console.WriteLine("------------");
                }
            }else{
                for(int i = 0; i < animais.Count;i++){
                    Console.WriteLine($"Nome do animal: {animais[i].Nome}");
                    Console.WriteLine($"Peso do animal: {animais[i].Peso}");
                    Console.WriteLine("------------");
                }
            }
        }

        private static IEnumerable<Animal> GetAnimaisComPesoMaiorQue(List<Animal> animais, int peso){

            foreach(Animal A in animais){
                if(A.Peso > peso){
                    yield return A;
                }
            }

        }
        
    }
}
