
using static System.Console;
namespace JuegoGato.Entidades
{
    class Tablero
    {
        public int Filas { get; set; }
        public int Columnas { get; set; }
        public const string FICHA_VACIA = "| |";
        public Ficha[][] Matriz { get; set; }
        
        
        public Tablero(int filas,int columnas)
        {
            Filas = filas;
            Columnas = columnas;
            int [,] Matriz = new int[filas,columnas];
            cabeceraHorizontal();
            mostrarTablero();
        }

        public void mostrarTablero(){
            for (int i = 0; i < Filas; i++)
            {
                int contador = 1;
                WriteLine();
                Write(i+1);//cabecera vertical
                Write(FICHA_VACIA);

                while (contador < Columnas)
                {
                    Write(FICHA_VACIA);
                    contador++;
                }
            }
       
       
        }

        public void cabeceraHorizontal(){
            for (int i = 0; i < Columnas; i++)
            {
                Write("  "+(i+1));
            }
        }

        public void mostrarFicha(Ficha fichaAMostrar){
            WriteLine(fichaAMostrar.ToString());
        }

        public void insertarFicha(){
            
        }

    }
}