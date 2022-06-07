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

        public String getMarca()
        {
            return this.Marca.getNombre();
        }

        public String getNombre()
        {
            return this.nombre;
        }
    }
}
