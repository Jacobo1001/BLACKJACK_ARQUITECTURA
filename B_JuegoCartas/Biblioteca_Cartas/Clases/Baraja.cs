using Biblioteca_Cartas.Eventos;
using System;
using System.Collections.Generic;

namespace Biblioteca_Cartas.Clases
{
    public class Baraja : Carta
    {
        internal PublisherValorCarta ValorCarta { get; }
        public List<Baraja> BarajaJuego { get; }

        internal void EventHandler()
        {
        }

        public Baraja(string descripcion) : base(0, 0, descripcion)
        {
            BarajaJuego = new List<Baraja>();

            ValorCarta = (descripcion == null)
                ? throw new ArgumentNullException(nameof(descripcion), "La carta no tiene ningún valor.")
                : new PublisherValorCarta();

            ValorCarta.evt_carta += EventHandler;
            Punto_carta = ValorCarta.Dar_Valor_Carta(descripcion);
        }
    }
}

