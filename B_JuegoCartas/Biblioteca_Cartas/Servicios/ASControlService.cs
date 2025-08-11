using System.Linq;
using System.Collections.Generic;
using Biblioteca_Cartas.Clases;

namespace Biblioteca_Cartas.Servicios
{
    public class ASControlService : IASControlService
    {
        public void ControlAS(List<Carta> cartasJugador)
        {
            int sumatoria_J = cartasJugador.Sum(carta => carta.Punto_carta);
            cartasJugador.Where(carta => sumatoria_J > 21 && carta.Descripcion == "AS").ToList().ForEach(carta => carta.Punto_carta = 1);
        }
    }
}
