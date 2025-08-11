using System;
using System.Collections.Generic;

namespace Biblioteca_Cartas.Clases
{
    public class Premio : Carta
    {
        public List<Premio> Baraja_Premio;

        public Premio(string descripcion) :
            base(0, 5, descripcion)
        {
            try
            {
                this.Baraja_Premio = (!string.IsNullOrEmpty(descripcion) && !string.IsNullOrWhiteSpace(descripcion))
                    ? new List<Premio>() : throw new Exception("La descripcion del premio es invalida");
            }
            catch (Exception e)
            {
                throw new Exception("Error en el constructor de Premio: " + e.Message);
            }
        }

    }
}

