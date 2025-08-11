using Biblioteca_Cartas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca_Cartas.Eventos
{
    internal class PublisherCartasComodin
    {
        private int contador_Partida;

        public int Contador_Partida { get => contador_Partida; }

        internal delegate void delegado_CComodin();
        internal event delegado_CComodin evt_Comodin;

        public void Suma_PComodin(List<Carta> Cartas_Jugador)
        {
            try
            {
                contador_Partida += PuntosComodinJugador(Cartas_Jugador);
            }
            catch (Exception e)
            {
                throw new Exception("Error en el publicador de calcular los puntos comodin " + e.Message);
            }
        }


        //FUNCION PARA SUMAR PUNTOS EXTRA DE JUGADOR
        internal int PuntosComodinJugador(List<Carta> cartas_jugador)
        {
            try
            {
                return cartas_jugador.Sum(carta => carta.Valor_juego != 0 ? carta.Valor_juego : 0);
            }
            catch (Exception e)
            {
                throw new Exception("Error en calcular puntos comodin del jugador: " + e.Message);
            }
        }
    }
}
