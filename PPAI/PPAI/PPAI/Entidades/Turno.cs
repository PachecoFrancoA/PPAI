using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Turno
    {
        private DateTime? fechaGeneracion { get; set; }
        private DateTime? fechaHoraInicio { get; set; }
        private DateTime? fechaHoraFin { get; set; }

        public Turno(DateTime? fechaGeneracion, DateTime? fechaHoraInicio, DateTime? fechaHoraFin)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
        }

        public void setFechaGeneracion(DateTime? fechaGeneracion)
        {
            this.fechaGeneracion = fechaGeneracion;
        }

        public DateTime? getFechaGeneracion()
        {
            return this.fechaGeneracion;
        }

        public void setFechaHoraInicio(DateTime? fechaHoraInicio)
        {
            this.fechaHoraInicio = fechaHoraInicio;
        }

        public DateTime? getFechaHoraInicio()
        {
            return this.fechaHoraInicio;
        }

        public void setFechaHoraFin(DateTime? fechaHoraFin)
        {
            this.fechaHoraFin = fechaHoraFin;
        }

        public DateTime? getFechaHoraFin()
        {
            return this.fechaHoraFin;
        }
    }
}
