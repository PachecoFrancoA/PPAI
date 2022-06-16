using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Entidades;

namespace PPAI.Entidades
{
    public class RecursoTecnologico 
    {

        // hacer un metodo para que se ordenen solos segun el tipo de recurso
        private int numeroRT { get; set; }
        private DateTime? fechaAlta { get; set; }

        private TipoRT tipoRT { get; set; }
        private Modelo modelo { get; set; }

        private List<CambioEstadoRT> cambiosEstado;

        private List<Turno> turnos;

        private List<Mantenimiento> mantenimientos;

        public RecursoTecnologico(int numero, DateTime? fechaAlta, TipoRT tipoRT, Modelo modelo)
        {
            this.numeroRT = numero;
            this.fechaAlta = fechaAlta;
            this.tipoRT = tipoRT;
            this.modelo = modelo;
            this.cambiosEstado = new List<CambioEstadoRT>();
            this.turnos = new List<Turno>();
            this.mantenimientos = new List<Mantenimiento>();
        }

        

        public int getNumero()
        {
            return this.numeroRT;
        }
        public TipoRT getTipoRT()
        {
            return this.tipoRT;
        }
        public Modelo getModelo()
        {
            return this.modelo;
        }

        public string getMarca()
        {
            return this.modelo.getMarca();
        }


        public void setNumero(int numero)
        {
            this.numeroRT = numero;
        }

        public void setFechaAlta(DateTime? fechaAlta)
        {
            this.fechaAlta = fechaAlta;
        }

        public void setModelo(Modelo modelo)
        {
            this.modelo = modelo;
        }

        public void setTipoRT(TipoRT tipoRT)
        {
            this.tipoRT = tipoRT;
        }

        public bool estaDisponible(Estado disponible)
        {
            foreach (CambioEstadoRT cambio in this.cambiosEstado)
            {
                if (cambio.esUltimo())
                {
                    if (cambio.esDisponible(disponible))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void agregarCambioEstado(Estado estado)
        {
            CambioEstadoRT cambio = new CambioEstadoRT(DateTime.Now, estado);
            this.cambiosEstado.Add(cambio);
        }
        
        public void agregarTurno(Turno turno)
        {
            this.turnos.Add(turno);
        }
        
        public bool esTuNumero(int num)
        {
            if (this.numeroRT == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Turno> getTurnos()
        {
            return this.turnos;
        }

        public List<Turno> buscarTurnosConfOPdteConf(DateTime fechaHoraFin, Estado estadoPdteConfirmacion, Estado estadoConfirmado)
        {
            List<Turno> turnosConfirmadosOPdteConfirmacion = new List<Turno>();

            foreach (Turno turno in this.turnos)
            {
                if (turno.esConfirmadoOPdteConfirmacion(fechaHoraFin, estadoPdteConfirmacion, estadoConfirmado))
                {
                    turnosConfirmadosOPdteConfirmacion.Add(turno);
                }
            }
            
            return turnosConfirmadosOPdteConfirmacion;
        }

        public void crearMantenimientoCorrectivo(DateTime? fechaFinPrevista, string motivo)
        {
            Mantenimiento nuevo = new Mantenimiento(DateTime.Now, fechaFinPrevista, motivo);
            this.mantenimientos.Add(nuevo);
        }

        public void cancelarTurnos(List<Turno> turnosACancelar, Estado canceladoPorMC)
        {
            foreach (Turno turno in turnosACancelar)
            {
                turno.cancelarPorMC(canceladoPorMC);
            }
        }

        
        

    }
}