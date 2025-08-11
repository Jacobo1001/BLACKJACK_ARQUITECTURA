using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cartas.Clases
{
    public class Resto
    {
        public List<Carta> cartas_restantes;
        public Carta c_sacada;

        public Resto(List<Baraja> cartas_Baraja, List<Premio> cartas_Premio, List<Castigo> cartas_Castigo)
        {
            this.cartas_restantes = new List<Carta>(cartas_Baraja);
            this.cartas_restantes.AddRange(cartas_Premio);
            this.cartas_restantes.AddRange(cartas_Castigo);

            Carta[] crt_rest_arr = cartas_restantes.ToArray();
            Random rnd = new Random();
            Array.Sort(crt_rest_arr, (a, b) => rnd.Next(-1, 2));
            cartas_restantes = new List<Carta>(crt_rest_arr);
        }

        public Carta Sacar_carta()
        {
            c_sacada = cartas_restantes[0];
            cartas_restantes.RemoveAt(0);
            return c_sacada;
        }
    }
}
