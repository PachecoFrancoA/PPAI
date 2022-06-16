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

        public CambioEstadoRT(DateTime? fechaHoraDesde, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.estado = estado;
            this.fechaHoraHasta = null;
        }

        public CambioEstadoRT()
        {
        }

        public bool esUltimo()
        {
            if (this.fechaHoraHasta.Equals(null))
            {
                return true;
            }
            return false;
        }

        public bool esDisponible(Estado disponible)
        {
            if (this.estado.Equals(disponible))
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