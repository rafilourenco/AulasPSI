using System;

namespace OMeuJogoMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar o modelo
            Inimigo[] array;

            Console.WriteLine("Introduza a quantidade de inimigos: ");
            int quant = Convert.ToInt32(Console.ReadLine());
            array = new Inimigo[quant];


            // Criar o controlador, passando uma referência aos elementos do modelo
            Controller controller = new Controller(array);

            // Criar a view, passando uma referência ao controlador
            View view = new View(controller);

            // Correr o jogo, passando uma referência da view ao controlador
            controller.Iniciar(view);



        }
    }
}
