using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Sesion
    {
        public DateTime? FechaHoraFin { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public Usuario usuario { get; set; }

        public Usuario conocerUsuario()
        {
            return this.usuario;
        }

    }
}
