using Biblioteca_Cartas.Clases;

namespace Biblioteca_Cartas.Servicios
{
    public class CartaService : ICartaService
    {
        public void EntregarCartas(Jugador jugador, Resto resto, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                jugador.cartas_jugador.Add(resto.Sacar_carta());
            }
        }
        public void EntregarCarta(Jugador jugador, Resto resto)
        {
            jugador.cartas_jugador.Add(resto.Sacar_carta());
        }
    }
}
