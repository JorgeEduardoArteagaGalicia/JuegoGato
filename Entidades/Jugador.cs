using static System.Console;
namespace JuegoGato.Entidades
{
    class Jugador
    {
        public int PartidasGanadas { get; set; }
        public int PartidasPerdidas { get; set; }
        public string Nombre { get; set; }
        public Ficha ficha { get; set; }//Establecemos un objeto de la clase Ficha con el nombre ficha
        public Jugadas unaJugada { get; set; }
        //Solicitamos el nombre y el el tipo de ficha
        public Jugador(string nombre, string esX){
            Nombre= nombre;
            ficha = new Ficha(esX);//Instanciamos para crear la ficha correspondiente
            PartidasGanadas = 0;//Inicializamos las partidas ganadas y perdidas
            PartidasPerdidas = 0;

        }

        public void seleccionarJugada(){
           WriteLine("Ingresa el valor en el eje \'X\'");
           int ejeX = int.Parse(ReadLine());
           unaJugada.PosX=ejeX;
           WriteLine("Ingresa el valor en el eje \'Y\'");
           int ejeY = int.Parse(ReadLine());
           unaJugada.PosY=ejeY;
        }
        
       

    }
}