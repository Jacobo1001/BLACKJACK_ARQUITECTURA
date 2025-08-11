using Biblioteca_Cartas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca_Cartas.Eventos
{
    internal class PublisherFinalPartida
    {
        private int resultado_actual;

        public int Resultado_actual { get => resultado_actual; }

        internal delegate void delegado_FinalPartida();
        internal event delegado_FinalPartida evt_Final;
        public void Resultado_Partida(List<Carta> Cartas_Jugador, List<Carta> Cartas_Maquina)
        {
            try
            {
                int resultado_Jugador = sumarCartas(Cartas_Jugador);
                int resultado_Maquina = sumarCartas(Cartas_Maquina);
                resultado_actual = resultado_Juego(resultado_Maquina, resultado_Jugador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el resultado de la partida: " + ex.Message);
            }
        }

        //FUNCION PARA SUMAR PUNTOS

        internal int sumarCartas(List<Carta> cartasJugador)
        {
            try
            {
                int sumatoria = cartasJugador.Sum(carta => carta.Punto_carta);
                return sumatoria;
            }
            catch (Exception e)
            {
                throw new Exception("Error sumatoria cartas " + e.Message);
            }
        }

        internal int resultado_Juego(int resultado_Maquina, int resultado_Jugador)
        {
            return (resultado_Jugador <= 21 && resultado_Maquina <= 21) ?
                (resultado_Jugador > resultado_Maquina ? 1 :
                    (resultado_Jugador < resultado_Maquina ? -1 : 0)) :
                (resultado_Jugador <= 21 && resultado_Maquina > 21 ? 1 :
                    (resultado_Jugador > 21 && resultado_Maquina <= 21 ? -1 : 0));
        }
    }
}
