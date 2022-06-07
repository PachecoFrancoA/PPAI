using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class TipoRT
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public String getNombre()
        {
            return this.nombre;
        }
    }
}
