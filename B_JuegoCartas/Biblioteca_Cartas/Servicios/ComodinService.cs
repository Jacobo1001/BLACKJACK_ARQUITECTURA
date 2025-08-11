using System.Collections.Generic;
using System.Linq;
using Biblioteca_Cartas.Clases;

namespace Biblioteca_Cartas.Servicios
{
    public class ComodinService : IComodinService
    {
        public void ComodinMaquina(List<Carta> cartasMaquina, Resto resto)
        {
            List<Carta> ListaRemover = cartasMaquina.Where(carta => carta.Valor_juego != 0).ToList();
            ListaRemover.ForEach(cartaRemover =>
            {
                cartasMaquina.Remove(cartaRemover);
                cartasMaquina.Add(resto.Sacar_carta());
            });
        }
    }
}
