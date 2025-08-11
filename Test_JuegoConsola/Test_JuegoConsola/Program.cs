using Biblioteca_Cartas.Clases;
using Biblioteca_Cartas.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_JuegoConsola
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Instanciar servicios SOLID
            var valorCartaService = new ValorCartaService();
            var mezclaCartasService = new MezclaCartasService();
            var extraccionCartaService = new ExtraccionCartaService();
            var creacionCartasService = new CreacionCartasService(valorCartaService);
            var apuestaService = new ApuestaService();
            var cartaService = new CartaService();
            var partidaService = new PartidaService();
            var asControlService = new ASControlService();
            var comodinService = new ComodinService();

            Jugador j1 = new Jugador("Jacobo");
            Console.WriteLine(j1.Apodo + " " + j1.Puntos);

            // Crear el juego con todas las dependencias
            Juego ju1 = new Juego(
                j1.Puntos,
                "Jacobo",
                apuestaService,
                cartaService,
                partidaService,
                asControlService,
                comodinService,
                creacionCartasService,
                mezclaCartasService,
                extraccionCartaService

            );

            Console.WriteLine("Saldo actual: " + ju1.ObtenerSaldo());

            Console.WriteLine("¿Cuánto quieres apostar?");
            int cantidadApostada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ju1.Apostar(cantidadApostada));
            Console.WriteLine(ju1.contador_PGenerales);

            foreach (Baraja baraja in ju1.Cartas_Baraja)
            {
                Console.WriteLine(baraja.Descripcion + " " + baraja.Punto_carta + " " + baraja.Valor_juego);
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(
                string.Join("\n", ju1.Cartas_res.cartas_restantes.Select(c => c.Descripcion))
            );

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Cartas jugador iniciales: ");
            Console.WriteLine(
                  string.Join("\n", ju1.j1.cartas_jugador.Select(c => c.Descripcion))
            );

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Cartas maquina iniciales: ");
            Console.WriteLine(
                    string.Join("\n", ju1.maquina.cartas_jugador.Select(c => c.Descripcion))
            );

            Console.WriteLine("----------------------------------------");

            // Si tienes métodos refactorizados para comodines y pedir cartas, adáptalos aquí
            // ju1.CartasComodin(ju1.j1.Cartas_jugador, ju1.maquina.cartas_jugador);
            // ju1.Pedir_CMaquina();

            ju1.Jugar(true, cantidadApostada);

            Console.WriteLine("\nLas cartas de la maquina luego de pedir cartas: ");
            Console.WriteLine(string.Join("\n", ju1.maquina.cartas_jugador.Select(c => c.Descripcion)));

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(ju1.contador_PGenerales);

            Console.WriteLine("¿Cuánto quieres apostar?");
            int cantidadApostada1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}