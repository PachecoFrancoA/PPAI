using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Sesion
    {
        private DateTime? fechaHoraFin { get; set; }
        private DateTime? fechaHoraInicio { get; set; }
        private Usuario usuario { get; set; }

        public Sesion()
        {
            
        }

        public Sesion(DateTime? fechaHoraInicio, Usuario usuario)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.usuario = usuario;
        }

        public void setFechaHoraFin(DateTime? fechaHoraFin)
        {
            this.fechaHoraFin = fechaHoraFin;
        }

        public DateTime? getFechaHoraFin()
        {
            return this.fechaHoraFin;
        }

        public void setFechaHoraInicio(DateTime? fechaHoraInicio)
        {
            this.fechaHoraInicio = fechaHoraInicio;
        }

        public DateTime? getFechaHoraInicio()
        {
            return this.fechaHoraInicio;
        }

        public void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public Usuario getUsuario()
        {
            return this.usuario;
        }



    }
}