using System.Linq;
using System.Collections.Generic;
using Biblioteca_Cartas.Clases;

namespace Biblioteca_Cartas.Servicios
{
    public class PartidaService : IPartidaService
    {
        public int CalcularResultado(List<Carta> cartasJugador, List<Carta> cartasMaquina)
        {
            int resultado_Jugador = cartasJugador.Sum(carta => carta.Punto_carta);
            int resultado_Maquina = cartasMaquina.Sum(carta => carta.Punto_carta);
            return resultado_Juego(resultado_Maquina, resultado_Jugador);
        }

        private int resultado_Juego(int resultado_Maquina, int resultado_Jugador)
        {
            return (resultado_Jugador <= 21 && resultado_Maquina <= 21) ?
                (resultado_Jugador > resultado_Maquina ? 1 :
                    (resultado_Jugador < resultado_Maquina ? -1 : 0)) :
                (resultado_Jugador <= 21 && resultado_Maquina > 21 ? 1 :
                    (resultado_Jugador > 21 && resultado_Maquina <= 21 ? -1 : 0));
        }
    }
}
