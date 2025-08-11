using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Biblioteca_Cartas.Clases;
using Biblioteca_Cartas.Servicios;

namespace Biblioteca_Cartas.Servicios
{
    public class CreacionCartasService : ICreacionCartasService
    {
        private readonly IValorCartaService valorCartaService;
        public CreacionCartasService(IValorCartaService valorCartaService)
        {
            this.valorCartaService = valorCartaService;
        }
        public void CreacionCartas(List<Baraja> cartasBaraja, List<Castigo> cartasCastigo, List<Premio> cartasPremio)
        {
            try
            {
                File.ReadAllLines(LeerArchivoTexto("Baraja.txt"))
                    .ToList()
                    .ForEach(linea => cartasBaraja.Add(new Baraja(linea, valorCartaService)));

                File.ReadAllLines(LeerArchivoTexto("castigo.txt"))
                    .ToList()
                    .ForEach(linea => cartasCastigo.Add(new Castigo(linea)));

                File.ReadAllLines(LeerArchivoTexto("Premio.txt"))
                    .ToList()
                    .ForEach(linea => cartasPremio.Add(new Premio(linea)));
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer el archivo de baraja: " + e.Message);
            }
        }

        public string LeerArchivoTexto(string nombre_archivo)
        {
            return "C:\\Users\\jacob\\Desktop\\NUEVO PROYECTO POO\\ArchivosTXT\\" + nombre_archivo;
        }
    }
}
