using System;

namespace Labo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador();
            jugador.Nombre="Haziel";
            jugador.SetArmaStrategy(new Pistola());

            jugador.Disparar();

            Jugador jugador2 = new Jugador();
            jugador.Nombre = "Nazaret";
            jugador.SetArmaStrategy(new Bazooka());

            jugador.Disparar();

            Jugador jugador3 = new Jugador();
            jugador.Nombre = "Alfredo";
            jugador.SetArmaStrategy(new Fusil());

            jugador.Disparar();




            Console.ReadKey();
        }
    }
}
