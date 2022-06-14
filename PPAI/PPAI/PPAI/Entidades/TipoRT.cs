using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class TipoRT
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }

        public TipoRT(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public TipoRT()
        {
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }
    }
}
