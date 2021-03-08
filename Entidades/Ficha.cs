using System;
using static System.Console;
namespace JuegoGato.Entidades
{

    class Ficha
    {
        //Son constantes por que no van a cambiar su valor
        public const string VALOR_X = "X";
        public const string VALOR_O = "O";
        public const string SEPARADOR = "|";
        string ficha;
        //Solicitamos un string para asignar el tipo de ficha
        public Ficha(string ficha){
            this.ficha=ficha;
            if(ficha == "x" || ficha == "X"){
                this.ficha=VALOR_X;
            }else
            {
                this.ficha=VALOR_O;
            }
        }
     

        public override string ToString()
        {
            return ficha;
        }

    }

}