using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Turno
    {
        public DateTime? fechaGeneracion { get; set; }
        public DateTime? fechaHoraIncio { get; set; }
        public DateTime? fechaHoraFin { get; set; }
    }
}
