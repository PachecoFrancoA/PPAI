using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Marca
    {
        private string nombre { get; set; }

        public Marca(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

    }
}
