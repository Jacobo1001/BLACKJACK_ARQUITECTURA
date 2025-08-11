using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca_Cartas.Clases
{
    public class Jugador
    {
        private string apodo;
        public int Puntos { get; }
        public List<Carta> cartas_jugador;

        private Random Punto_Random = new Random();
        public Jugador(string apodo)
        {
            try
            {
                Apodo = apodo;
                this.cartas_jugador = new List<Carta>();

                Puntos = Punto_Random.Next(50, 81);
            }
            catch (Exception e)
            {
                throw new Exception("Error en el constructor de Jugador: " + e.Message);
            }
        }
        public List<Carta> Cartas_jugador { get => cartas_jugador; set => cartas_jugador = value; }
        public string Apodo
        {
            get => apodo; set => apodo = (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value) && value.Length >= 3)
                ? value : throw new Exception("El apodo debe ser mayor a 3 caracteres");
        }
    }
}

