using System;
using System.Collections.Generic;

namespace Biblioteca_Cartas.Clases
{
    public class Castigo : Carta
    {
        public List<Castigo> Baraja_Castigo { get; }

        public Castigo(string descripcion) : base(0, -5, descripcion) =>
            Baraja_Castigo = (!string.IsNullOrWhiteSpace(descripcion)) ? new List<Castigo>() :
            throw new ArgumentException("La descripcion del castigo es invalida", nameof(descripcion));
    }
}

