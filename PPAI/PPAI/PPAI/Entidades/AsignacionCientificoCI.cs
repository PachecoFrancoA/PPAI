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
        private PersonalCientifico personalCientifico { get; set; }
        private List<Turno> turnos { get; set; }

        public AsignacionCientificoCI(PersonalCientifico personalCientifico, List<Turno> turnos)
        {
            this.personalCientifico = personalCientifico;
            this.turnos = turnos;
        }



        public PersonalCientifico getPersonalCientifico()
        {
            return this.personalCientifico;
        }

        public List<Turno> getTurnos()
        {
            return this.turnos;
        }

        public void setPersonCienti(PersonalCientifico persCient)
        {
            this.personalCientifico = persCient;
        }

        public void setTurnos(List<Turno> turnos)
        {
            this.turnos = turnos;
        }


    }
}
