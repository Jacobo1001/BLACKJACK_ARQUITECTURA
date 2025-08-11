using System;
using System.Collections.Generic;
using Biblioteca_Cartas.Clases;

namespace Biblioteca_Cartas.Servicios
{
    public class ExtraccionCartaService : IExtraccionCartaService
    {
        public Carta SacarCarta(List<Carta> cartas_restantes)
        {
            if (cartas_restantes == null || cartas_restantes.Count == 0)
                throw new InvalidOperationException("No hay cartas restantes para sacar.");
            Carta c_sacada = cartas_restantes[0];
            cartas_restantes.RemoveAt(0);
            return c_sacada;
        }
    }
}
