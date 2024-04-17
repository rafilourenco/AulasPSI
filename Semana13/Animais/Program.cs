using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
           Animal[] animais = new Animal[10];
           Random random = new Random();
           for(int i = 0; i < animais.Length;i++){
                int randomNumber = random.Next(1,5);
                switch(randomNumber){
                    case 1:
                        animais[i] = new Gato();
                        break;
                    case 2:
                        animais[i] = new Cao();
                        break;
                    case 3:
                        animais[i] = new Abelha();
                        break;
                    case 4:
                        animais[i] = new Morcego();
                        break;
                }
                Console.WriteLine(animais[i].Som());
                if(animais[i] is IMamifero){
                    Console.WriteLine($"Número de mamilos {animais[i]}: "+(((IMamifero)animais[i]).NumeroDeMamilos));
                }
                if(animais[i] is IVoador){
                    Console.WriteLine($"Número de asas {animais[i]}: "+(((IVoador)animais[i]).NumeroDeAsas));
                }
           }
        }
    }
}
