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


        public CambioEstadoTurno()
        {

        }
        public CambioEstadoTurno(DateTime? fechaHoraDesde, DateTime? fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
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

        public bool esUltimo()
        {
            if (this.fechaHoraHasta.Equals(null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esConfOPdteConf(Estado estadoConfirmado, Estado estadoPdteConfirmacion)
        {
            if (this.estado.Equals(estadoConfirmado) || this.estado.Equals(estadoPdteConfirmacion))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool estaDentroPlazoMantenimiento(DateTime? fechaFinPrevista)
        {
            if (this.fechaHoraDesde.Value.Date <= DateTime.Now.Date && this.fechaHoraHasta.Value.Date >= fechaFinPrevista)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}