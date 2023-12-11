using System;

namespace BCPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar instancias de cor

            Cor vermelho = new Cor(255, 0, 0);
            Cor verde = new Cor(0, 255, 0);
            Cor azul = new Cor(0, 0, 255);
            Cor amarelo = new Cor(255, 255, 0);



            int quant;
            int Qvezes;
            Bola[] arrayBola;


            Console.WriteLine("Introduza a quantidade de bolas: ");
            quant = Convert.ToInt32(Console.ReadLine());
            arrayBola = new Bola[quant];

            //Criar algumas bolas
            Bola bola01 = new Bola(cor01, 5);



            //Atirar as bolas várias vezes

            Console.WriteLine("Quantas vezes deseja atirar as bolas?");
            Qvezes = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < Qvezes; i++){
                .Atirar();
            }
            
            //Rebentar algumas das bolas

            bola01.Pop();
            bola03.Pop();

            //Imprimir no ecrã o estado de cada uma (incluindo cor)

            Console.WriteLine("Dados das bolas: \n");
            //Imprimir Bola 1
            Console.WriteLine("Bola 1:");
            Console.WriteLine($"Cor: {cor01.Red}, {cor01.Green}, {cor01.Blue}");
            Console.WriteLine($"Vezes atirada: {bola01.Vezes}");
            if(bola01.Raio == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");
            //Imprimir Bola 2
            Console.WriteLine("Bola 2:");
            Console.WriteLine($"Cor: {cor02.Red}, {cor02.Green}, {cor02.Blue}");
            Console.WriteLine($"Vezes atirada: {bola02.Vezes}");
            if(bola02.Raio == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");
            //Imprimir Bola 3
            Console.WriteLine("Bola 3:");
            Console.WriteLine($"Cor: {cor03.Red}, {cor03.Green}, {cor03.Blue}");
            Console.WriteLine($"Vezes atirada: {bola03.Vezes}");
            if(bola03.Raio == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");
            //Imprimir Bola 4
            Console.WriteLine("Bola 4:");
            Console.WriteLine($"Cor: {cor04.Red}, {cor04.Green}, {cor04.Blue}");
            Console.WriteLine($"Vezes atirada: {bola04.Vezes}");
            if(bola04.Raio == 0){
                Console.WriteLine("Foi arrebentada?Sim");
            }else{
                Console.WriteLine("Foi arrebentada?Não");
            }
            Console.WriteLine("\n");
        }
    }
}
