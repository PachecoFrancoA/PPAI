using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Estado
    {
        public string nombre { get; set; }
        public string ambito { get; set; }

        public string conocerNombre()
        {
            return this.nombre;
        }
        public string conocerAmbito()
        {
            return this.ambito;
        }
    }
    
}
