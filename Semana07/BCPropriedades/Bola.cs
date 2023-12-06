using System;

namespace BCPropriedades
{
    class Bola
    {   

        //Construtores apropriados
        public Bola(Cor cor, double raio){
            Cor = cor;
            Raio = raio;
            Vezes = 0;
        }
        //Método Pop() que fura a bola (coloca o seu raio a zero)
        public void Pop(){
            Raio = 0;
        }
        //Método Atirar() que incrementa o nº de vezes que a bola foi atirada (apenas se a bola não estiver furada)
        public void Atirar(){
            if(Raio > 0){
                Vezes++;
            }
        }


        //Propriedades Get e Set
        public Cor Cor{get;}

        public double Raio{get;private set;}

        //Método que retorna o nº de vezes que a bola foi atirada
        public int Vezes{get;private set;}


    }

}