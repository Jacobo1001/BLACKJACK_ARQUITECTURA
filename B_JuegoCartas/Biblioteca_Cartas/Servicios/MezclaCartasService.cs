using System;
using System.Collections.Generic;
using Biblioteca_Cartas.Clases;

namespace Biblioteca_Cartas.Servicios
{
    public class MezclaCartasService : IMezclaCartasService
    {
        public List<Carta> MezclarCartas(List<Carta> cartas)
        {
            Carta[] crt_rest_arr = cartas.ToArray();
            Random rnd = new Random();
            Array.Sort(crt_rest_arr, (a, b) => rnd.Next(-1, 2));
            return new List<Carta>(crt_rest_arr);
        }
    }
}
