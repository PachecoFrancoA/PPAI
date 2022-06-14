using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CambioEstadoTurno
    {
        private DateTime? fechaHoraDesde { get; set; }
        private DateTime? fechaHoraHasta { get; set; }
        private Estado estado { get; set; }



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