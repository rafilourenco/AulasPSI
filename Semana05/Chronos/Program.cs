using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Declarar e instanciar dois cronómetros
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            // Iniciar contagem do tempo em cron1
            cron1.Start();

            // Pausar o programa durante 1 segundo:
            Thread.Sleep(1000);

            // Iniciar contagem do tempo em cron2
            cron2.Start();

            // Pausar o programa durante mais 1 segundo
            Thread.Sleep(1000);

            //Parar contagem do tempo nos dois cronómetros
            cron1.Stop();
            cron2.Stop();

            // Mostrar no ecrã tempo decorrido em cada um dos cronómetros, em milissegundos
            Console.WriteLine("Cronometro 1: "+cron1.ElapsedMilliseconds);
            Console.WriteLine("Cronometro 2: "+cron2.ElapsedMilliseconds);

            /*
            1: cron1, cron2 de stopwatch
            2: Sim
            3: Tempo Decorrido
            




            */
        }
    }
}
