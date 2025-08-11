using Biblioteca_Cartas.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cartas.Eventos
{
    internal class PublisherCreacionCartas
    {
        internal delegate void delegado_CreacionListas();
        internal event delegado_CreacionListas evt_listas;

        public void Creacion_Cartas(List<Baraja> cartas_Baraja, List<Castigo> cartas_Castigo, List<Premio> cartas_Premio)
        {
            try
            {
                // Leer y procesar el archivo "Baraja.txt"
                File.ReadAllLines(LeerArchivoTexto("Baraja.txt"))
                    .ToList()
                    .ForEach(linea => cartas_Baraja.Add(new Baraja(linea)));

                // Leer y procesar el archivo "castigo.txt"
                File.ReadAllLines(LeerArchivoTexto("castigo.txt"))
                    .ToList()
                    .ForEach(linea => cartas_Castigo.Add(new Castigo(linea)));

                // Leer y procesar el archivo "Premio.txt"
                File.ReadAllLines(LeerArchivoTexto("Premio.txt"))
                    .ToList()
                    .ForEach(linea => cartas_Premio.Add(new Premio(linea)));
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer el archivo de baraja: " + e.Message);
            }
        }
        public string LeerArchivoTexto(string nombre_archivo)
        {
            try
            {
                return "C:\\Users\\jacob\\Desktop\\NUEVO PROYECTO POO\\ArchivosTXT\\" + nombre_archivo;
            }
            catch (Exception e)
            {
                throw new Exception("El archivo es erroneo, verifique la ruta " + e);
            }
        }
    }
}
