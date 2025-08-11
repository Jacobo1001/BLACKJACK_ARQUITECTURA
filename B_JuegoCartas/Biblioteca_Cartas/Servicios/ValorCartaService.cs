using System;
using System.Collections.Generic;

namespace Biblioteca_Cartas.Servicios
{
    public interface IValorCartaService
    {
        int DarValorCarta(string descripcion);
    }

    public class ValorCartaService : IValorCartaService
    {
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

        public int DarValorCarta(string descripcion)
        {
            string carta = descripcion.ToUpper().Trim();
            if (valoresCartas.ContainsKey(carta))
                return valoresCartas[carta];
            throw new Exception("La carta tiene una descripción errónea: " + descripcion);
        }
    }
}
