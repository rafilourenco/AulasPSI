using System;

namespace Skynet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta1;
            string resposta2;
            string resposta3;
            string resposta4;
            string resposta5;
            int pontos = 0;
            bool exit = false;

            do{

                Console.WriteLine("Está pronto para responder? ");
                resposta1 = Console.ReadLine();
                
                if (resposta1 == "Pronto" || resposta1 == "Sim" || resposta1 == "sim" || resposta1 == "pronto"){
                    Console.WriteLine("Perfeito!");
                }else{
                    Console.WriteLine("Então?");

                Console.WriteLine("Primeira pergunta:\nQuem foi Antonio Oliveira Salazar?");
                resposta2 = Console.ReadLine();
                

                if (resposta2 == "Ditador" || resposta2 == "Ditador Portugues" || resposta2 == "ditador" || resposta2 == "ditador portugues"){
                    Console.WriteLine("Certo!");
                    pontos = pontos + 1;
                }else{
                    Console.WriteLine("Errado!");
                }



                if (pontos == 1){
                    Console.WriteLine("Tem " + pontos + " ponto!");
                }else{
                    Console.WriteLine("Tem " + pontos + " pontos!");
                }


                Console.WriteLine("Segunda pergunta:\nPortugal é um pais Europeu?");
                resposta3 = Console.ReadLine();
                    
                if (resposta3 == "sim" || resposta3 == "Sim" || resposta3 == "correto" || resposta3 == "Correto" || resposta3 == "Claro" || resposta3 == "claro"){
                    Console.WriteLine("Certo!");
                    pontos = pontos + 1;
                }else{
                    Console.WriteLine("Errado!");
                }


                if (pontos == 1)
                {
                    Console.WriteLine("Tem " + pontos + " ponto!");
                }else{
                    Console.WriteLine("Tem " + pontos + " pontos!");
                }

                Console.WriteLine("Terceira pergunta:\nBrasil é uma colonia portuguesa?");
                resposta4 = Console.ReadLine();
                    
                if (resposta4 == "sim" || resposta4 == "Sim" || resposta4 == "correto" || resposta4 == "Correto" || resposta4 == "Claro" || resposta4 == "claro"){
                    Console.WriteLine("Certo!");
                    pontos = pontos + 1;
                }else{
                    Console.WriteLine("Errado!Seras deportado amanha!");
                }

                if (pontos == 1){
                    Console.WriteLine("Tem " + pontos + " ponto!");
                }else{
                    Console.WriteLine("Tem " + pontos + " pontos!");
                }


                switch (pontos){
                    case 0:
                        Console.WriteLine("Não tem direito a um premio.");
                        break;
                    case 1:
                        Console.WriteLine("Tem direito a um premio pequeno.");
                        break;
                    case 2:
                        Console.WriteLine("Tem direito a um premio médio.");
                        break;
                    case 3:
                        Console.WriteLine("Tem direito a um premio grande.");
                        break;
                    }    
                
                Console.WriteLine("Introduza Exit para terminar, ou nada, para continuar.");
                resposta5 = Console.ReadLine();
                
                
                 
            }
        }while (!exit);
    }
}
}        