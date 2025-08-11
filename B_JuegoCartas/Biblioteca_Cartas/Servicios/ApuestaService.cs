using Biblioteca_Cartas.Servicios;
using System.Linq;

namespace Biblioteca_Cartas.Servicios
{
    public class ApuestaService : IApuestaService
    {
        public string Apostar(int saldoActual, int cantidadApostada, out int saldoFinal)
        {
            if (cantidadApostada > saldoActual)
            {
                saldoFinal = saldoActual;
                return "No tienes suficiente saldo para realizar esa apuesta.";
            }
            if (cantidadApostada <= 0)
            {
                saldoFinal = saldoActual;
                return "La apuesta debe ser mayor a cero.";
            }
            saldoFinal = saldoActual - cantidadApostada;
            return $"Apuesta realizada. Nuevo saldo: {saldoFinal}";
        }
    }
}
