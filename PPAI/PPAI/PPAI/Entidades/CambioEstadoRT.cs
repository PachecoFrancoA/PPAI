using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CambioEstadoRT
    {
        public DateTime? fechaHoraDesde { get; set; }
        public DateTime? fechaHoraHasta { get; set; }
        public Estado Estado { get; set; }

        public Boolean esUltimo()
        {
            DateTime fechaActual = DateTime.Now;
            if (this.fechaHoraHasta == null)
            {
                return true;
            }
            return false;
        }

        public Boolean esDisponible(Estado disponible)
        {
            if(this.Estado == disponible)
            {
                return true;
            }
            return false;
        }
    }

    
}
