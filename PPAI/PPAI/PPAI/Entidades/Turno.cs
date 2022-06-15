using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Turno
    {
        private DateTime fechaGeneracion { get; set; }
        private DateTime fechaHoraInicio { get; set; }
        private DateTime fechaHoraFin { get; set; }

        private List<CambioEstadoTurno> cambiosEstado;

        private AsignacionCientificoCI asignacionCientificoCI;

        public Turno(DateTime fechaGeneracion, DateTime fechaHoraInicio, DateTime fechaHoraFin, AsignacionCientificoCI asignacionCientificoCI)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.asignacionCientificoCI = asignacionCientificoCI;
            this.cambiosEstado = new List<CambioEstadoTurno>();
        }

        public void setFechaGeneracion(DateTime fechaGeneracion)
        {
            this.fechaGeneracion = fechaGeneracion;
        }

        public DateTime getFechaGeneracion()
        {
            return this.fechaGeneracion;
        }

        public void setFechaHoraInicio(DateTime fechaHoraInicio)
        {
            this.fechaHoraInicio = fechaHoraInicio;
        }

        public DateTime getFechaHoraInicio()
        {
            return this.fechaHoraInicio;
        }

        public void setFechaHoraFin(DateTime fechaHoraFin)
        {
            this.fechaHoraFin = fechaHoraFin;
        }

        public DateTime getFechaHoraFin()
        {
            return this.fechaHoraFin;
        }
        
        public void agregarCambioTurno(CambioEstadoTurno cambio)
        {
            this.cambiosEstado.Add(cambio);
        }

        public List<CambioEstadoTurno> getCambiosEstado()
        {
            return this.cambiosEstado;
        }

        public bool esConfirmadoOPdteConfirmacion(DateTime fechaHoraFin, Estado estadoPdteConfirmacion, Estado estadoConfirmado)
        {

            CambioEstadoTurno ultimo = new CambioEstadoTurno();
            foreach (CambioEstadoTurno cambio in cambiosEstado)
            {
                if (cambio.esUltimo())
                {
                    ultimo = cambio;
                }
            }

            if (ultimo.esConfOPdteConf(estadoConfirmado, estadoPdteConfirmacion) && ultimo.estaDentroPlazoMantenimiento(fechaHoraFin))
            {
                return true;
            }
            return false;
        }

        public AsignacionCientificoCI getAsignacionCientificoCI()
        {
            return this.asignacionCientificoCI;
        }

      
        public int compareTo(Turno turnoB)
        {
            return this.asignacionCientificoCI.compareTo(turnoB.getAsignacionCientificoCI());
        }
       
    }
}
