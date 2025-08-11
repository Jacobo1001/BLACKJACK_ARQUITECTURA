using System;
using System.Collections.Generic;
using Biblioteca_Cartas.Servicios;

namespace Biblioteca_Cartas.Clases
{
    public class Resto
    {
        public List<Carta> cartas_restantes;
        public Carta c_sacada;
        private readonly IMezclaCartasService mezclaService;
        private readonly IExtraccionCartaService extraccionService;

        public Resto(List<Baraja> cartas_Baraja, List<Premio> cartas_Premio, List<Castigo> cartas_Castigo,
            IMezclaCartasService mezclaService,
            IExtraccionCartaService extraccionService)
        {
            this.mezclaService = mezclaService;
            this.extraccionService = extraccionService;
            var todasCartas = new List<Carta>(cartas_Baraja);
            todasCartas.AddRange(cartas_Premio);
            todasCartas.AddRange(cartas_Castigo);
            cartas_restantes = mezclaService.MezclarCartas(todasCartas);
        }

        public Carta Sacar_carta()
        {
            c_sacada = extraccionService.SacarCarta(cartas_restantes);
            return c_sacada;
        }
    }
}
