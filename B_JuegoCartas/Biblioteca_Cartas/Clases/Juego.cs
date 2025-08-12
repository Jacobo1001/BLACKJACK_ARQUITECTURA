using System.Collections.Generic;
using System.Linq;
using System;
using Biblioteca_Cartas.Servicios;

namespace Biblioteca_Cartas.Clases
{
    public class Juego
    {
        private readonly IApuestaService apuestaServicio;
        private readonly ICartaService cartasServicio;
        private readonly IPartidaService partidaServicio;
        private readonly IASControlService controlAsServicio;
        private readonly IComodinService comodinServicio;
        private readonly IinicializacionJuegoServicio inicializacionJuegoServicio;

        private List<Premio> cartasPremio;
        private List<Castigo> cartasCastigo;
        private List<Baraja> cartasBaraja;
        private Resto resto;
        private Jugador jugador;
        private Jugador maquina;
        private int saldo;

        public Juego(
            int saldoInicial,
            string apodoJugador,
            IApuestaService apuestaServicio,
            ICartaService cartasServicio,
            IPartidaService partidaServicio,
            IASControlService controlAsServicio,
            IComodinService comodinServicio,
            IinicializacionJuegoServicio inicializacionJuegoServicio)
        {
            this.apuestaServicio = apuestaServicio;
            this.cartasServicio = cartasServicio;
            this.partidaServicio = partidaServicio;
            this.controlAsServicio = controlAsServicio;
            this.comodinServicio = comodinServicio;
            this.inicializacionJuegoServicio = inicializacionJuegoServicio;
            this.saldo = saldoInicial;

            InicializarJuego(apodoJugador);
        }

        private void InicializarJuego(string apodoJugador)
        {
            (cartasBaraja, cartasCastigo, cartasPremio, resto, jugador, maquina) = inicializacionJuegoServicio.Inicializar(apodoJugador);
        }

        public string Apostar(int cantidadApostada)
        {
            int saldoFinal;
            var resultado = apuestaServicio.Apostar(saldo, cantidadApostada, out saldoFinal);
            saldo = saldoFinal;
            return resultado;
        }

        public int ObtenerSaldo() => saldo;

        public void EntregarCartaAJugador(bool esJugador)
        {
            cartasServicio.EntregarCarta(esJugador ? jugador : maquina, resto);
        }

        public void PedirCartasMaquina()
        {
            for (int i = 0; i < 2; i++)
            {
                int suma = maquina.cartas_jugador.Sum(c => c.Punto_carta);
                if (suma <= 15)
                {
                    cartasServicio.EntregarCarta(maquina, resto);
                    controlAsServicio.ControlAS(maquina.cartas_jugador);
                    comodinServicio.ComodinMaquina(maquina.cartas_jugador, resto);
                }
            }
        }

        public void Jugar(bool plantarse, int cantidadApostada)
        {
            if (plantarse)
            {
                int resultado = partidaServicio.CalcularResultado(jugador.cartas_jugador, maquina.cartas_jugador);
                if (resultado == 1)
                    saldo += (cantidadApostada * 2);
                else if (resultado == 0)
                    saldo += cantidadApostada;
                // Si pierde, no suma nada
            }
            else
            {
                cartasServicio.EntregarCarta(jugador, resto);
            }
        }
    }
}