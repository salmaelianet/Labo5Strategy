using System;
using System.Collections.Generic;
using System.Text;

namespace Labo5
{
    class Jugador
    {
        public string Nombre { get; set; }
        IArmaStrategy _armaStrategy;



        public void SetArmaStrategy(IArmaStrategy armaStrategy)
        {
            this._armaStrategy = armaStrategy; 
        }

        public void Disparar()
        {
            Console.WriteLine (Nombre);
            Console.WriteLine(_armaStrategy.Disparar());
        }

        
    }
}
