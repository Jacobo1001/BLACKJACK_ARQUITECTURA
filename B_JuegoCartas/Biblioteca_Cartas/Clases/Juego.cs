using System.Collections.Generic;
using System.Linq;
using System;
using Biblioteca_Cartas.Servicios;

namespace Biblioteca_Cartas.Clases
{
    public class Juego
    {
        private readonly IApuestaService apuestaService;
        private readonly ICartaService cartaService;
        private readonly IPartidaService partidaService;
        private readonly IASControlService asControlService;
        private readonly IComodinService comodinService;
        private readonly ICreacionCartasService creacionCartasService;
        private readonly IMezclaCartasService mezclaCartasService;
        private readonly IExtraccionCartaService extraccionCartaService;

        internal List<Premio> cartas_Premio = new List<Premio>();
        internal List<Castigo> cartas_Castigo = new List<Castigo>();
        public List<Baraja> cartas_Baraja = new List<Baraja>();
        public Resto Cartas_res;
        public Jugador j1;
        public Jugador maquina;

        public int contador_PGenerales;
        public int cant_apostada;

        public Juego(
            int contador_PGenerales,
            string NikeName,
            IApuestaService apuestaService,
            ICartaService cartaService,
            IPartidaService partidaService,
            IASControlService asControlService,
            IComodinService comodinService,
            ICreacionCartasService creacionCartasService,
            IMezclaCartasService mezclaCartasService,
            IExtraccionCartaService extraccionCartaService)
        {
            this.apuestaService = apuestaService;
            this.cartaService = cartaService;
            this.partidaService = partidaService;
            this.asControlService = asControlService;
            this.comodinService = comodinService;
            this.creacionCartasService = creacionCartasService;
            this.mezclaCartasService = mezclaCartasService;
            this.extraccionCartaService = extraccionCartaService;

            this.contador_PGenerales = contador_PGenerales;

            creacionCartasService.CreacionCartas(cartas_Baraja, cartas_Castigo, cartas_Premio);

            Cartas_res = new Resto(cartas_Baraja, cartas_Premio, cartas_Castigo, mezclaCartasService, extraccionCartaService);

            j1 = new Jugador(NikeName);
            maquina = new Jugador("Maquina");

            cartaService.EntregarCartas(j1, Cartas_res, 2);
            cartaService.EntregarCartas(maquina, Cartas_res, 2);

            asControlService.ControlAS(j1.cartas_jugador);
            asControlService.ControlAS(maquina.cartas_jugador);
            comodinService.ComodinMaquina(maquina.cartas_jugador, Cartas_res);

            Apostar(cant_apostada);
        }

        public string Apostar(int cantidadApostada)
        {
            int saldoFinal;
            var resultado = apuestaService.Apostar(contador_PGenerales, cantidadApostada, out saldoFinal);
            contador_PGenerales = saldoFinal;
            return resultado;
        }

        public int ObtenerSaldo()
        {
            return contador_PGenerales;
        }

        public void EntregarCartaAJugador(bool aJugador)
        {
            cartaService.EntregarCarta(aJugador ? j1 : maquina, Cartas_res);
        }

        public void Pedir_CMaquina()
        {
            for (int i = 0; i < 2; i++)
            {
                int sumatoria = maquina.cartas_jugador.Sum(carta => carta.Punto_carta);
                if (sumatoria <= 15)
                {
                    cartaService.EntregarCarta(maquina, Cartas_res);
                    asControlService.ControlAS(maquina.cartas_jugador);
                    comodinService.ComodinMaquina(maquina.cartas_jugador, Cartas_res);
                }
            }
        }

        public void Jugar(bool plantarse, int cant_apostada)
        {
            if (plantarse)
            {
                int resultado = partidaService.CalcularResultado(j1.cartas_jugador, maquina.cartas_jugador);
                if (resultado == 1)
                    contador_PGenerales += (cant_apostada * 2);
                else if (resultado == 0)
                    contador_PGenerales += cant_apostada;
                // Si pierde, no suma nada
            }
            else
            {
                cartaService.EntregarCarta(j1, Cartas_res);
            }
        }
    }
}
