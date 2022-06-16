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
            Usuario usu2 = new Usuario("user2", "0002");
            usuarios.Add(usu2);
            usuarios = new List<Usuario>();
            Usuario usu3 = new Usuario("user3", "0003");
            usuarios.Add(usu3);
            usuarios = new List<Usuario>();
            Usuario usu4 = new Usuario("user4", "0004");
            usuarios.Add(usu4);
            usuarios = new List<Usuario>();
            Usuario usu5 = new Usuario("user5", "0005");
            usuarios.Add(usu5);
            usuarios = new List<Usuario>();
            Usuario usu6 = new Usuario("user6", "0006");
            usuarios.Add(usu6);
            usuarios = new List<Usuario>();
            Usuario usu7 = new Usuario("user7", "0007");
            usuarios.Add(usu7);
            usuarios = new List<Usuario>();
            Usuario usu8 = new Usuario("user8", "0008");
            usuarios.Add(usu8);
            usuarios = new List<Usuario>();
            Usuario usu9 = new Usuario("user9", "0009");
            usuarios.Add(usu9);
            usuarios = new List<Usuario>();
            Usuario usu10 = new Usuario("user10", "0010");
            usuarios.Add(usu10);


            //Sesiones
            // poner usuario 1 cuando queremos que haya recursos
            // poner usuario 3 cuando no queremos que haya recursos
            sesiones = new List<Sesion>();
            Sesion ses1 = new Sesion(DateTime.Now.Date, usu1);
            //Sesion ses1 = new Sesion(DateTime.Now.Date, usu3);
            sesiones.Add(ses1);

            //Personal Cientifico
            personalCientificos = new List<PersonalCientifico>();
            PersonalCientifico personal1 = new PersonalCientifico(82387, "Juan", "juan@gmail.com", "juan@gmail.com", usu1);
            personalCientificos.Add(personal1);
            PersonalCientifico personal2 = new PersonalCientifico(85152, "Martin", "martin@gmail.com", "martin@gmail.com", usu2);
            personalCientificos.Add(personal2);
            PersonalCientifico personal3 = new PersonalCientifico(82356, "Pepe", "pepe@gmail.com", "pepe@gmail.com", usu3);
            personalCientificos.Add(personal3);
            PersonalCientifico personal4 = new PersonalCientifico(82487, "Facundo", "facundo@gmail.com", "facundo@gmail.com", usu4);
            personalCientificos.Add(personal4);
            PersonalCientifico personal5 = new PersonalCientifico(82587, "Carlos", "carlos@gmail.com", "carlos@gmail.com", usu5);
            personalCientificos.Add(personal5);
            PersonalCientifico personal6 = new PersonalCientifico(82797, "Ezequiel", "eze@gmail.com", "eze@gmail.com", usu6);
            personalCientificos.Add(personal6);
            PersonalCientifico personal7 = new PersonalCientifico(83387, "Camila", "cami@gmail.com", "cami@gmail.com", usu7);
            personalCientificos.Add(personal7);
            PersonalCientifico personal8 = new PersonalCientifico(84387, "Analia", "analuz@gmail.com", "analuz@gmail.com", usu8);
            personalCientificos.Add(personal8);
            PersonalCientifico personal9 = new PersonalCientifico(79387, "Federico", "federico@gmail.com", "federico@gmail.com", usu9);
            personalCientificos.Add(personal9);
            PersonalCientifico personal10 = new PersonalCientifico(85487, "Alejo", "ale@gmail.com", "ale@gmail.com", usu10);
            personalCientificos.Add(personal10);

            // Cambios Estado RT
            cambiosEstadoRT = new List<CambioEstadoRT>();
            CambioEstadoRT cambio1 = new CambioEstadoRT(DateTime.Now.Date, datosSoporte.getEstadoDisponibleRecursoTecnologico());
            CambioEstadoRT cambio2 = new CambioEstadoRT(new DateTime(2022, 05, 23), datosSoporte.getEstadoDisponibleRecursoTecnologico());


            // Recursos Tecnologicos
            //Recursos Tecnologicos
            recursos = new List<RecursoTecnologico>();
            RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico(1, DateTime.Now.Date, datosSoporte.tiposRT[0], datosSoporte.modelos[0]);
            recursoTecnologico1.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico1);
            RecursoTecnologico recursoTecnologico2 = new RecursoTecnologico(2, DateTime.Now.Date, datosSoporte.tiposRT[1], datosSoporte.modelos[1]);
            recursoTecnologico2.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico2);
            RecursoTecnologico recursoTecnologico3 = new RecursoTecnologico(3, DateTime.Now.Date, datosSoporte.tiposRT[2], datosSoporte.modelos[2]);
            recursoTecnologico3.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico3);
            RecursoTecnologico recursoTecnologico4 = new RecursoTecnologico(4, DateTime.Now.Date, datosSoporte.tiposRT[3], datosSoporte.modelos[3]);
            recursoTecnologico4.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico4);
            RecursoTecnologico recursoTecnologico5 = new RecursoTecnologico(5, DateTime.Now.Date, datosSoporte.tiposRT[4], datosSoporte.modelos[4]);
            recursoTecnologico5.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico5);
            RecursoTecnologico recursoTecnologico6 = new RecursoTecnologico(6, DateTime.Now.Date, datosSoporte.tiposRT[5], datosSoporte.modelos[5]);
            recursoTecnologico6.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico6);
            RecursoTecnologico recursoTecnologico7 = new RecursoTecnologico(7, DateTime.Now.Date, datosSoporte.tiposRT[1], datosSoporte.modelos[6]);
            recursoTecnologico7.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico7);
            RecursoTecnologico recursoTecnologico8 = new RecursoTecnologico(8, DateTime.Now.Date, datosSoporte.tiposRT[2], datosSoporte.modelos[7]);
            recursoTecnologico8.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico8);
            RecursoTecnologico recursoTecnologico9 = new RecursoTecnologico(9, DateTime.Now.Date, datosSoporte.tiposRT[3], datosSoporte.modelos[8]);
            recursoTecnologico9.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico9);
            RecursoTecnologico recursoTecnologico10 = new RecursoTecnologico(10, DateTime.Now.Date, datosSoporte.tiposRT[4], datosSoporte.modelos[9]);
            recursoTecnologico10.agregarCambioEstado(datosSoporte.getEstadoDisponibleRecursoTecnologico());
            recursos.Add(recursoTecnologico10);

            // Asignaciones Cientifico CI
            asignacionesCientificoCI = new List<AsignacionCientificoCI>();
            AsignacionCientificoCI asignacionPC1 = new AsignacionCientificoCI(personal1);
            asignacionesCientificoCI.Add(asignacionPC1);
            AsignacionCientificoCI asignacionPC2 = new AsignacionCientificoCI(personal2);
            asignacionesCientificoCI.Add(asignacionPC2);
            AsignacionCientificoCI asignacionPC3 = new AsignacionCientificoCI(personal3);
            asignacionesCientificoCI.Add(asignacionPC3);
            AsignacionCientificoCI asignacionPC4 = new AsignacionCientificoCI(personal4);
            asignacionesCientificoCI.Add(asignacionPC4);
            AsignacionCientificoCI asignacionPC5 = new AsignacionCientificoCI(personal5);
            asignacionesCientificoCI.Add(asignacionPC5);
            

            // Turnos
            turnos = new List<Turno>();
            Turno turno1 = new Turno(new DateTime(2022, 6, 5), new DateTime(2022, 6, 18), new DateTime(2022, 7, 18), asignacionPC1);
            turno1.agregarCambioEstadoTurno(new DateTime(2022, 6, 5), datosSoporte.getEstadoConfirmadoTurno());
            asignacionPC1.agregarTurnos(turno1);
            recursoTecnologico1.agregarTurno(turno1);
            turnos.Add(turno1);
            
            Turno turno2 = new Turno(new DateTime(2022, 8, 4), new DateTime(2022, 8, 10), new DateTime(2022, 8, 12), asignacionPC1);
            turno2.agregarCambioEstadoTurno(new DateTime(2022, 8, 4), datosSoporte.getEstadoPdteConfirmacionTurno());
            asignacionPC1.agregarTurnos(turno2);
            recursoTecnologico1.agregarTurno(turno2);
            turnos.Add(turno2);
            
            Turno turno3 = new Turno(new DateTime(2022, 9, 2), new DateTime(2022, 9, 18), new DateTime(2022, 9, 20), asignacionPC2);
            turno3.agregarCambioEstadoTurno(new DateTime(2022, 9, 2), datosSoporte.getEstadoPdteConfirmacionTurno());
            asignacionPC1.agregarTurnos(turno3);
            recursoTecnologico1.agregarTurno(turno3);
            turnos.Add(turno3);
            
            Turno turno4 = new Turno(new DateTime(2022, 10, 11), new DateTime(2022, 10, 14), new DateTime(2022, 10, 22), asignacionPC3);
            turno4.agregarCambioEstadoTurno(new DateTime(2022, 10, 11), datosSoporte.getEstadoPdteConfirmacionTurno());
            asignacionPC1.agregarTurnos(turno4);
            recursoTecnologico1.agregarTurno(turno4);
            turnos.Add(turno4);
            
            Turno turno5 = new Turno(new DateTime(2022, 11, 1), new DateTime(2022, 11, 7), new DateTime(2022, 11, 27), asignacionPC4);
            turno5.agregarCambioEstadoTurno(new DateTime(2022, 11, 1), datosSoporte.getEstadoPdteConfirmacionTurno());
            asignacionPC1.agregarTurnos(turno5);
            recursoTecnologico1.agregarTurno(turno5);
            turnos.Add(turno5);
            
            Turno turno6 = new Turno(new DateTime(2022, 12, 4), new DateTime(2022, 12, 8), new DateTime(2022, 12, 12), asignacionPC5);
            turno6.agregarCambioEstadoTurno(new DateTime(2022, 12, 4), datosSoporte.getEstadoPdteConfirmacionTurno());
            asignacionPC1.agregarTurnos(turno6);
            recursoTecnologico1.agregarTurno(turno6);
            turnos.Add(turno6);


            // Cambios Estado Turno
            cambiosEstadoTurno = new List<CambioEstadoTurno>();

            

            

            // Asignaciones Responsable Tecnico RT
            asignacionesResponsableTecnicoRT = new List<AsignacionResponsableTecnicoRT>();
            AsignacionResponsableTecnicoRT asignacionP1RT1 = new AsignacionResponsableTecnicoRT(DateTime.Now.Date, personal1);
            asignacionP1RT1.agregarRecurso(recursoTecnologico1);
            asignacionP1RT1.agregarRecurso(recursoTecnologico2);
            asignacionP1RT1.agregarRecurso(recursoTecnologico3);
            asignacionP1RT1.agregarRecurso(recursoTecnologico4);
            asignacionesResponsableTecnicoRT.Add(asignacionP1RT1);

            AsignacionResponsableTecnicoRT asignacionP2RT1 = new AsignacionResponsableTecnicoRT(DateTime.Now.Date, personal2);
            asignacionP2RT1.agregarRecurso(recursoTecnologico1);
            asignacionP2RT1.agregarRecurso(recursoTecnologico7);
            asignacionP2RT1.agregarRecurso(recursoTecnologico8);
            asignacionesResponsableTecnicoRT.Add(asignacionP2RT1);





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
                    break;
                }
            }
            // busco la asignacion del usuario y le pido sus RT disponibles
            foreach (AsignacionResponsableTecnicoRT asignacion in this.asignacionesResponsableTecnicoRT)
            {
                if (asignacion.getPersonalCientifico().Equals(personalCientificoUsuario))
                {
                    recursosTecnologicosDisponibles = asignacion.getRTDisponibles(EstadoDisponible);
                    break;
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
