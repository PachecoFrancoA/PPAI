using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Modelo
    {
        private string nombre { get; set; }
        private Marca Marca { get; set; }

        public Modelo(string nombre, Marca marca)
        {
            this.nombre = nombre;
            Marca = marca;
        }

        public void setMarca(string nombre)
        {
            this.nombre = nombre;
        }

        public String getMarca()
        {
            return this.Marca.getNombre();
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
