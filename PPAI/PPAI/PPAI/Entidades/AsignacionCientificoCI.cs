using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class AsignacionCientificoCI
    {
        //public DateTime? fechaDesde { get; set; }
        //public DateTime? fechaHasta { get; set; }
        public PersonalCientifico personalCientifico { get; set; }
        public List<Turno> turnos { get; set; }

    }
}
