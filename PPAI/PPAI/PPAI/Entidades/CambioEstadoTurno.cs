using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CambioEstadoTurno
    {
        public DateTime? fechaHoraDesde { get; set; }
        public DateTime? fechaHoraHasta { get; set; }
        public Estado Estado { get; set; }
    }
}
