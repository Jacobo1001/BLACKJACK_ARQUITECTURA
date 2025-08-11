using System;
using System.Collections.Generic;
using Biblioteca_Cartas.Servicios;

namespace Biblioteca_Cartas.Clases
{
    public class Baraja : Carta
    {
        public List<Baraja> BarajaJuego { get; }
        public Baraja(string descripcion, IValorCartaService valorCartaService) : base(0, 0, descripcion)
        {
            if (descripcion == null)
                throw new ArgumentNullException(nameof(descripcion), "La carta no tiene ningún valor.");
            BarajaJuego = new List<Baraja>();
            Punto_carta = valorCartaService.DarValorCarta(descripcion);
        }
    }
}

