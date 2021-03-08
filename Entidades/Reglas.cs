using System;
using static System.Console;//Creamos estatuco el paquete Console para reducir codigo

namespace JuegoGato.Entidades
{
    class Reglas
    {
        public static void MostrarReglas(){//Creamos un metodo estatico por que no es conveniente que se cree una instancia de esta clase
            string j1, j2;//Declaramos las variables para los nombres
            

            WriteLine("Bienvenidos al juego del gato!");
            WriteLine("Ingresa el nombre del Jugador 1 : ");
            j1 = ReadLine();
            WriteLine("Ingresa el nombre del Jugador 2 : ");
            j2 = ReadLine();
            //Instanciamos los 2 jugadores con los 2 parametros establecidos
            var jugador1 = new Jugador(j1,"X");
            var jugador2 = new Jugador(j2,"O");
            
            WriteLine("==========>Reglas<==========\nDebes ingresar el numero de Filas y el numero de Columnas\nTambien deberas igresar cuantas fichas en linea se necesita para ganar");
            //Establecemos quien comienza el juego
           
           creacionTablero();
          

            if (jugadorInicia() == 1)
            {
                WriteLine("\n>>>>> " + jugador1.Nombre + " tu comienzas el juego <<<<<");
            }
            else
            {
                WriteLine("\n>>>>> " + jugador2.Nombre + " tu comienzas el juego <<<<<");
            }
      

        }

        public static int jugadorInicia()
        {
            int turno;
            Random aleatorio = new Random();
            turno = aleatorio.Next(1, 3);
            return turno;
        }

        public static void creacionTablero(){
            int filas, columnas;
            WriteLine("¿Cuantas Filas quieres?");
            filas = int.Parse(ReadLine());
            WriteLine("¿Cuantas Columnas quieres?");
            columnas = int.Parse(ReadLine());

            var tablero = new Tablero(filas, columnas);
        }

    }
}