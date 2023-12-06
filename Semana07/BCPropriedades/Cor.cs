using System;


namespace BCPropriedades
{
    class Cor
    {

        
        //Estado cinzento
        private int cinzento;

        //Construtor que aceita todos os parâmetros necessários para inicializar o estado de uma cor
        public Cor(int red, int green, int blue, int alpha){
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        //Construtor que aceita red, green, blue, e coloca alpha a 255
        public Cor(int red, int green, int blue){
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        //Propriedades get e set
        public int Red{get;set;}
        public int Green{get;set;}
        public int Blue{get;set;}
        public int Alpha{get;set;}


        //Propriedade getter para obter o grau de cinzento da cor, igual à média dos valores red, green e blue
        public int GetCinzento{
            get{
                cinzento = (Red + Green + Blue) / 3;
                return cinzento;
            }
            
        }


    }



}