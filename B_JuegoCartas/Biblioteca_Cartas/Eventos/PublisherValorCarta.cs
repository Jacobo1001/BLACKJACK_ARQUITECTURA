using System;
using System.Collections.Generic;

namespace Biblioteca_Cartas.Eventos
{
    internal class PublisherValorCarta
    {
        internal delegate void delegado_carta();
        internal event delegado_carta evt_carta;

        private readonly Dictionary<string, int> valoresCartas = new Dictionary<string, int>
        {
            { "AS", 11 },
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "6", 6 },
            { "7", 7 },
            { "8", 8 },
            { "9", 9 },
            { "10", 10 },
            { "J", 10 },
            { "Q", 10 },
            { "K", 10 }
        };
        public int Dar_Valor_Carta(string descripcion)
        {
            try
            {
                evt_carta?.Invoke();

                string carta = descripcion.ToUpper().Trim();
                return valoresCartas.ContainsKey(carta) ? valoresCartas[carta] : throw new Exception("La carta tiene una descripción errónea: " + descripcion);
            }
            catch (Exception e)
            {
                throw new Exception("El valor de la carta no es válido: " + e.Message);
            }
        }
    }
}
