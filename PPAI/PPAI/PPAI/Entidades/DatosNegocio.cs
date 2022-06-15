using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class DatosNegocio
    {
        public List<PersonalCientifico> personalCientificos;

        public List<AsignacionCientificoCI> asignacionesCientificoCI;

        public List<AsignacionResponsableTecnicoRT> asignacionesResponsableTecnicoRT;

        public List<CambioEstadoRT> cambiosEstadoRT;

        public List<CambioEstadoTurno> cambiosEstadoTurno;

        public List<Sesion> sesiones;

        public List<Turno> turnos;

        public List<Usuario> usuarios;

        public DatosSoporte datosSoporte;

        public List<RecursoTecnologico> recursos;

        public DatosNegocio(DatosSoporte datosSoporte)
        {
            //Usuarios
            usuarios = new List<Usuario>();
            Usuario usu1 = new Usuario("ppai", "ppai");
            usuarios.Add(usu1);

            //Sesiones
            sesiones = new List<Sesion>();
            Sesion ses1 = new Sesion(DateTime.Now.Date, usu1);
            sesiones.Add(ses1);

            //Personal Cientifico
            personalCientificos = new List<PersonalCientifico>();
            PersonalCientifico personal1 = new PersonalCientifico(82387, "Juan", "juan@gmail.com", "juan@gmail.com", usu1);
            personalCientificos.Add(personal1);

            // Asignaciones Cienftifico CI
            asignacionesCientificoCI = new List<AsignacionCientificoCI>();
            AsignacionCientificoCI asignacionPC1 = new AsignacionCientificoCI(personal1);
            asignacionesCientificoCI.Add(asignacionPC1);

            // Turnos
            turnos = new List<Turno>();
            Turno turno1 = new Turno(new DateTime(2022, 6, 5), new DateTime(2022, 6, 18), new DateTime(2022, 7, 18), asignacionPC1);
            asignacionPC1.agregarTurnos(turno1);
            turnos.Add(turno1);
            

            // Cambios Estado Turno
            cambiosEstadoTurno = new List<CambioEstadoTurno>();

            // Cambios Estado RT
            cambiosEstadoRT = new List<CambioEstadoRT>();
            CambioEstadoRT cambio1 = new CambioEstadoRT(DateTime.Now.Date, datosSoporte.getEstadoDisponibleRecursoTecnologico());
            
            
            // Recursos Tecnologicos
            //Recursos Tecnologicos
            recursos = new List<RecursoTecnologico>();
            RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico(1, DateTime.Now.Date, datosSoporte.tiposRT[0], datosSoporte.modelos[0]);
            recursoTecnologico1.agregarCambioEstado(cambio1);
            recursos.Add(recursoTecnologico1);

            // Asignaciones Responsable Tecnico RT
            asignacionesResponsableTecnicoRT = new List<AsignacionResponsableTecnicoRT>();
            AsignacionResponsableTecnicoRT asignacionP1RT1 = new AsignacionResponsableTecnicoRT(DateTime.Now.Date, personal1);
            asignacionP1RT1.agregarRecurso(recursoTecnologico1);
            asignacionesResponsableTecnicoRT.Add(asignacionP1RT1);


            

            this.datosSoporte = datosSoporte;

        }

        public Sesion getSesionActual()
        {
            foreach (Sesion sesion in sesiones)
            {
                if (sesion.getFechaHoraInicio().Equals(DateTime.Now.Date))
                {
                    return sesion;
                }
            }
            return null;
        }

        public Usuario getUsuarioLogueado(Sesion sesionActual)
        {
            foreach (Sesion sesion in sesiones)
            {
                if (sesion.Equals(sesionActual))
                {
                    return sesion.getUsuario();
                }
            }
            return null;
        }

        public PersonalCientifico getPersonalCientificoUsuario(Usuario usuario)
        {
            foreach (PersonalCientifico personal in personalCientificos)
            {
                if (personal.getUsuario().Equals(usuario))
                {
                    return personal;
                }
            }
            return null;
        }

        public List<RecursoTecnologico> getRecursosTecnologicosDisponibles(Usuario usuario)
        {
            //busco estado disponible
            Estado EstadoDisponible = datosSoporte.getEstadoDisponibleRecursoTecnologico();
            //lista vacia de RT disponinbles
            List<RecursoTecnologico> recursosTecnologicosDisponibles = new List<RecursoTecnologico>();
            // personal vacio
            PersonalCientifico personalCientificoUsuario = new PersonalCientifico();
            // busco el personal del usuario
            foreach (PersonalCientifico personal in this.personalCientificos)
            {
                if (personal.getUsuario().Equals(usuario))
                {
                    personalCientificoUsuario = personal;
                }
            }
            // busco la asignacion del usuario y le pido sus RT disponibles
            foreach (AsignacionResponsableTecnicoRT asignacion in this.asignacionesResponsableTecnicoRT)
            {
                if (asignacion.getPersonalCientifico().Equals(personalCientificoUsuario))
                {
                    recursosTecnologicosDisponibles = asignacion.getRTDisponibles(EstadoDisponible);
                }
            }

            return recursosTecnologicosDisponibles;

        }

        public Turno getReservaTurno(RecursoTecnologico RTSeleccionado, DateTime fechaHoraFin, Estado estadoPdteConfirmacion, Estado estadoConfirmado)
        {

            List<Turno> turnosDelRTSeleccionado = RTSeleccionado.getTurnos();
            List<Turno> turnosConfirmadosOPdteConfirmacion = new List<Turno>();

            foreach (Turno turno in turnosDelRTSeleccionado)
            {
                //CambioEstadoTurno ultimoCambio = turno.getUltimoCambioEstado();
                if (turno.esConfirmadoOPdteConfirmacion(fechaHoraFin, estadoPdteConfirmacion, estadoConfirmado))
                {
                    turnosConfirmadosOPdteConfirmacion.Add(turno);
                }
            }
            return null;
        }
    }
}
