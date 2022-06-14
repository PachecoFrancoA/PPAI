using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.Interfaces;
using PPAI.Entidades;

namespace PPAI.Gestor
{
    public class GestorRegistrarMantenimientoCorrectivo
    {
        public GestorRegistrarMantenimientoCorrectivo(frmMenu _principal)
        {
            principal = _principal;
        }
        public frmMenu principal;
        public PersonalCientifico personalCientifico { get; set; }
        public AsignacionResponsableTecnicoRT asignacionResponsableTecnico { get; set; }
        public Sesion sesionActual = new Sesion()
        {
            FechaHoraInicio = DateTime.Now,
            usuario = new Usuario()
            {
                usuario = "ppai",
                password = "ppai",
            }
        };
        public FormularioSeleccionRT pantallaRT;

        public Estado estadoRT { get; set; }
        public List<RecursoTecnologico> recursoTecnologicos { get; set; }
        public RecursoTecnologico recursoSeleccionado { get; set; }
        public Estado disponible { get; set; }

        public Usuario usuarioLogueado { get; set; }



        public void opcionRegistrarMantenimientoCorrectivoRT()
        {
            pantallaRT = new FormularioSeleccionRT(this);

            disponible = buscarEstadoDisponible();

            asignacionResponsableTecnico = buscarAsginacionResponsable(sesionActual.conocerUsuario());

            recursoTecnologicos = buscarRTDisponibles(asignacionResponsableTecnico, disponible);

            pantallaRT.solicitarSeleccionRT(recursoTecnologicos);
            pantallaRT.Show();
            //recursoSeleccionado = enviarASolicitarSeleccion(recursoTecnologicos);
        }

        private Estado buscarEstadoDisponible()
        {
            Estado disponible = new Estado("Disponible", "Recurso Tecnologico");

            List<Estado> estados = new List<Estado>();
            estados.Add(disponible);

            foreach (Estado estado in estados)
            {
                if (estado.getAmbito() == "Recurso Tecnologico" && estado.getNombre() == "Disponible")
                {
                    disponible = estado;
                }
            }

            return disponible;
        }
        private AsignacionResponsableTecnicoRT buscarAsginacionResponsable(Usuario usuario)
        {
            DateTime fechaActual = DateTime.Now;

            PersonalCientifico personalCientifico = new PersonalCientifico(82387, "Juan", "juan@gmail.com", "juan@gmail.com", usuario);

            Estado disponible = new Estado("Disponible", "Recurso Tecnologico");

            CambioEstadoRT cambioEstadoRT = new CambioEstadoRT();
            cambioEstadoRT.fechaHoraDesde = new DateTime(2022, 6, 5);
            cambioEstadoRT.fechaHoraHasta = null;
            cambioEstadoRT.Estado = disponible;

            RecursoTecnologico recurso1 = new RecursoTecnologico();
            recurso1.numeroRT = 1;
            recurso1.cambiosEstado.Add(cambioEstadoRT);

            List<RecursoTecnologico> recursos = new List<RecursoTecnologico>();
            recursos.Add(recurso1);

            AsignacionResponsableTecnicoRT asignacionResponsableTecnicoRT = new AsignacionResponsableTecnicoRT();
            asignacionResponsableTecnicoRT.fechaDesde = DateTime.Now;
            asignacionResponsableTecnicoRT.personalCientifico = personalCientifico;
            asignacionResponsableTecnicoRT.recursoTecnologico = recursos;

            List<AsignacionResponsableTecnicoRT> asignaciones = new List<AsignacionResponsableTecnicoRT>();
            asignaciones.Add(asignacionResponsableTecnicoRT);

            foreach (AsignacionResponsableTecnicoRT asignacion in asignaciones)
            {
                if ((asignacion.esTuUsuario(usuario)))
                {
                    return asignacion;
                }
                //&& asignacion.esActual()
            }
            return null;

        }
        private List<RecursoTecnologico> buscarRTDisponibles(AsignacionResponsableTecnicoRT asignacion, Estado disponible)
        {
            return asignacion.misRTDisponibles(disponible);
            //return asignacion.mostrarRecursos();

        }
    }
}
