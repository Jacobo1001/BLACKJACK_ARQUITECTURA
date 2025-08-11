namespace Biblioteca_Cartas.Servicios
{
    public interface IApuestaService
    {
        string Apostar(int saldoActual, int cantidadApostada, out int saldoFinal);
    }
}
