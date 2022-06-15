using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CambioEstadoRT
    {
        private DateTime? fechaHoraDesde { get; set; }
        private DateTime? fechaHoraHasta { get; set; }
        private Estado estado { get; set; }

        public CambioEstadoRT(DateTime? fechaHoraDesde, DateTime? fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }

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
            if (this.estado == disponible)
            {
                return true;
            }
            return false;
        }


        public void setFechaHoraDesde(DateTime? fechaHoraDesde)
        {
            this.fechaHoraDesde = fechaHoraDesde;
        }

        public DateTime? getFechaHoraDesde()
        {
            return this.fechaHoraDesde;
        }

        public void setFechaHoraHasta(DateTime? fechaHoraHasta)
        {
            this.fechaHoraHasta = fechaHoraHasta;
        }

        public DateTime? getFechaHoraHasta()
        {
            return this.fechaHoraHasta;
        }

        public void setEstado(Estado estado)
        {
            this.estado = estado;
        }

        public Estado getEstado()
        {
            return this.estado;
        }








    }


}