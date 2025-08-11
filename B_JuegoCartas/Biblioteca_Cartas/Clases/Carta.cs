using System;

namespace Biblioteca_Cartas.Clases
{
    public class Carta
    {
        public int Punto_carta { get; set; }
        public int Valor_juego { get; }
        public string Descripcion { get; }

        public Carta(int punto_carta, int valor_juego, string descripcion)
        {
            Punto_carta = punto_carta;
            Valor_juego = valor_juego;
            Descripcion = descripcion;
        }
    }
}
