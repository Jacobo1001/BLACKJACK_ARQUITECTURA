namespace Biblioteca_Cartas.Servicios
{
    public interface IExtraccionCartaService
    {
        Biblioteca_Cartas.Clases.Carta SacarCarta(System.Collections.Generic.List<Biblioteca_Cartas.Clases.Carta> cartas_restantes);
    }
}
