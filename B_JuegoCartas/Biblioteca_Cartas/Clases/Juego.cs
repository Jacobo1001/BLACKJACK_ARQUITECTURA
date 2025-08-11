using Biblioteca_Cartas.Eventos;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Biblioteca_Cartas.Clases
{
    public class Juego
    {
        // LLAMAMOS LAS LISTAS QUE VAMOS A USAR EN JUEGO
        internal List<Premio> cartas_Premio = new List<Premio>();
        internal List<Castigo> cartas_Castigo = new List<Castigo>();
        internal List<Baraja> cartas_Baraja = new List<Baraja>();

        public Resto Cartas_res;
        public Jugador j1;
        public Jugador maquina;

        // ATRIBUTOS 
        public int contador_PGenerales;
        public int cant_apostada;

        // LLAMAMOS CREADOR DE CARTAS
        internal PublisherCreacionCartas crearCartas;
        internal PublisherFinalPartida finalizarPartida;
        internal PublisherCartasComodin cartasComodin;

        internal void EventHandler() { }

        // ACCESORES
        public int Contador_PGenerales { get => contador_PGenerales; set => contador_PGenerales = value; }
        public List<Premio> Cartas_Premio { get => cartas_Premio; }
        public List<Castigo> Cartas_Castigo { get => cartas_Castigo; }
        public List<Baraja> Cartas_Baraja { get => cartas_Baraja; }

        public Juego(int contador_PGenerales, string NikeName)
        {
            try
            {
                this.Contador_PGenerales = contador_PGenerales;

                // CREACION DE LOS DIFERENTES TIPOS DE CARTAS
                crearCartas = new PublisherCreacionCartas();
                crearCartas.evt_listas += EventHandler;
                crearCartas.Creacion_Cartas(cartas_Baraja, cartas_Castigo, cartas_Premio);

                Cartas_res = new Resto(cartas_Baraja, cartas_Premio, cartas_Castigo);

                j1 = new Jugador(NikeName);
                maquina = new Jugador("Maquina");

                Entregar_carta();
                ControlAS(j1.cartas_jugador);
                ControlAS(maquina.cartas_jugador);
                ComodinMaquina(maquina.cartas_jugador);

                Apostar(cant_apostada);
            }
            catch (Exception e)
            {
                throw new Exception("Error en el constructor de Juego: " + e.Message);
            }
        }

        // FUNCION LAMBDA PARA APOSTAR
        public string Apostar(int cantidadApostada)
        {
            try
            {
                Func<int, string> Apuesta = apuesta =>
                    apuesta > contador_PGenerales ? "No tienes suficiente saldo para realizar esa apuesta."
                    : apuesta <= 0 ? "La apuesta debe ser mayor a cero."
                    : (contador_PGenerales -= apuesta) >= 0 ? $"Apuesta realizada. Nuevo saldo: {contador_PGenerales}"
                    : string.Empty;

                return Apuesta(cantidadApostada);
            }
            catch (Exception e)
            {
                throw new Exception("Error al apostar: " + e.Message);
            }
        }

        // FUNCION PARA OBTENER SALDO
        public int ObtenerSaldo()
        {
            try
            {
                return contador_PGenerales;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el saldo: " + e.Message);
            }
        }

        // FUNCION CON SOBRECARGA PARA ENTREGAR CARTAS DURANTE Y ANTES DEL JUEGO
        public void Entregar_carta()
        {
            try
            {
                j1.cartas_jugador.Add(Cartas_res.Sacar_carta());
                j1.cartas_jugador.Add(Cartas_res.Sacar_carta());
                maquina.cartas_jugador.Add(Cartas_res.Sacar_carta());
                maquina.cartas_jugador.Add(Cartas_res.Sacar_carta());
            }
            catch (Exception e)
            {
                throw new Exception("Error al entregar carta: " + e.Message);
            }
        }

        public void Entregar_carta(bool aJugador)
        {
            try
            {
                (aJugador ? j1 : maquina).cartas_jugador.Add(Cartas_res.Sacar_carta());
            }
            catch (Exception e)
            {
                throw new Exception("Error al entregar carta: " + e.Message);
            }
        }

        // FUNCION PARA CONTROLAR AUTOMATIZACION DE LA MAQUINA
        public void Pedir_CMaquina(List<Carta> cartas_jugador)
        {
            try
            {
                Enumerable.Range(0, 2).ToList().ForEach(_ =>
                {
                    int sumatoria = cartas_jugador.Sum(carta => carta.Punto_carta);
                    if (sumatoria <= 15)
                    {
                        Entregar_carta(false);
                        ControlAS(cartas_jugador);
                        ComodinMaquina(cartas_jugador);
                    }
                });
            }
            catch (Exception e)
            {
                throw new Exception("Error en la función Pedir_CMaquina: " + e.Message);
            }
        }

        // FUNCION PARA CONTROLAR EL GANADOR DE LA PARTIDA
        public void Jugar(bool plantarse, int cant_apostada)
        {
            try
            {
                if (plantarse)
                {
                    finalizarPartida = new PublisherFinalPartida();
                    finalizarPartida.evt_Final += EventHandler;
                    finalizarPartida.Resultado_Partida(j1.cartas_jugador, maquina.cartas_jugador);

                    contador_PGenerales += (finalizarPartida.Resultado_actual == 1) ? (cant_apostada * 2) :
                        (finalizarPartida.Resultado_actual == -1) ? 0 : cant_apostada;

                }
                else
                {
                    Entregar_carta(true);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en funcion jugar " + e.Message);
            }
        }

        // FUNCION CONTROL CARTAS COMODIN JUGADOR Y MAQUINA
        public void CartasComodin(List<Carta> cartas_Jugador, List<Carta> cartas_Maquina)
        {
            try
            {
                cartasComodin = new PublisherCartasComodin();
                cartasComodin.evt_Comodin += EventHandler;
                cartasComodin.Suma_PComodin(cartas_Jugador);
                ComodinMaquina(cartas_Maquina);
                contador_PGenerales += cartasComodin.Contador_Partida;
            }
            catch (Exception e)
            {
                throw new Exception("Error en funcion cartas comodin " + e.Message);
            }
        }

        // FUNCION CONTROL CARTAS COMODIN MAQUINA
        public void ComodinMaquina(List<Carta> cartas_Maquina)
        {
            try
            {
                List<Carta> ListaRemover = cartas_Maquina.Where(carta => carta.Valor_juego != 0).ToList();

                ListaRemover.ForEach(cartaRemover =>
                {
                    cartas_Maquina.Remove(cartaRemover);
                    Entregar_carta(false);
                });
            }
            catch (Exception e)
            {
                throw new Exception("Error en el control de cartas comodin de la maquina " + e.Message);
            }
        }

        // FUNCION CONTROL DE AS
        public void ControlAS(List<Carta> cartas_Jugador)
        {
            try
            {
                int sumatoria_J = cartas_Jugador.Sum(carta => carta.Punto_carta);

                cartas_Jugador.Where(carta => sumatoria_J > 21 && carta.Descripcion == "AS").ToList().ForEach(carta => carta.Punto_carta = 1);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
