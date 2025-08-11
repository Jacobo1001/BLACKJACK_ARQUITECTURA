using Biblioteca_Cartas.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_JuegoConsola
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Jugador j1 = new Jugador("Jacobo");
            Console.WriteLine(j1.Apodo + " " + j1.Puntos);

            Juego ju1 = new Juego(j1.Puntos, "Jacobo");

            Console.WriteLine("Saldo actual: " + ju1.ObtenerSaldo());

            Console.WriteLine("¿Cuánto quieres apostar?");
            int cantidadApostada = Convert.ToInt32(Console.ReadLine());

            // Llamada al método Apostar de la clase Jugador
            Console.WriteLine(ju1.Apostar(cantidadApostada));

            Console.WriteLine(ju1.Contador_PGenerales);

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

            ju1.CartasComodin(ju1.j1.Cartas_jugador, ju1.maquina.cartas_jugador);
            //ju1.ComodinMaquina(ju1.maquina.cartas_jugador);
            ju1.Pedir_CMaquina(ju1.maquina.Cartas_jugador);
            //ju1.ComodinMaquina(ju1.maquina.cartas_jugador);
            ju1.Jugar(true, cantidadApostada);

            Console.WriteLine("\nLas cartas de la maquina luego de pedir cartas: ");
            Console.WriteLine(string.Join("\n", ju1.maquina.cartas_jugador.Select(c => c.Descripcion)));

            Console.WriteLine("----------------------------------------");



            Console.WriteLine(ju1.Contador_PGenerales);

            Console.WriteLine("¿Cuánto quieres apostar?");
            int cantidadApostada1 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
