using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca_Cartas.Clases;

namespace Biblioteca_Cartas.Servicios
{
    public interface ICartasComodinService
    {
        int SumaPComodin(List<Carta> cartasJugador);
    }

    public class CartasComodinService : ICartasComodinService
    {
        public int SumaPComodin(List<Carta> cartasJugador)
        {
            try
            {
                return cartasJugador.Sum(carta => carta.Valor_juego != 0 ? carta.Valor_juego : 0);
            }
            catch (Exception e)
            {
                throw new Exception("Error en calcular puntos comodin del jugador: " + e.Message);
            }
        }
    }
}
