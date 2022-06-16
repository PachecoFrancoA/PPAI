using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Mantenimiento
    {
        
        private DateTime? fechaInicio { get; set; }
        private DateTime? fechaFin { get; set; }
        private DateTime? fechaFinPrevista { get; set; }

        private string motivo { get; set; }

        public Mantenimiento(DateTime? fechaInicio, DateTime? fechaFinPrevista, string motivo)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFinPrevista = fechaFinPrevista;
            this.motivo = motivo;
        }

        public DateTime? getFechaInicio()
        {
            return this.fechaInicio;
        }

        public DateTime? getFechaFinPrevista()
        {
            return this.fechaFinPrevista;
        }

        public string getMotivo()
        {
            return this.motivo;
        }

        public void setFechaInicio(DateTime? fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }

        public void setFechaFinPrevista(DateTime? fechaFinPrevista)
        {
            this.fechaFinPrevista = fechaFinPrevista;
        }
        public void setMotivo(string motivo)
        {
            this.motivo = motivo;
        }

        
    }
}
