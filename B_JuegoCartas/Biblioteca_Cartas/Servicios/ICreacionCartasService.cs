namespace Biblioteca_Cartas.Servicios
{
    public interface ICreacionCartasService
    {
        void CreacionCartas(System.Collections.Generic.List<Biblioteca_Cartas.Clases.Baraja> cartasBaraja, System.Collections.Generic.List<Biblioteca_Cartas.Clases.Castigo> cartasCastigo, System.Collections.Generic.List<Biblioteca_Cartas.Clases.Premio> cartasPremio);
    }
}
