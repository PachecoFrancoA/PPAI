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

        public Usuario usuario;
        public Sesion sesionActual; 
        
        public FormularioSeleccionRT pantallaRT;

        public Estado estadoRT { get; set; }
        public List<RecursoTecnologico> recursoTecnologicos { get; set; }
        public RecursoTecnologico recursoSeleccionado { get; set; }
        public Estado disponible { get; set; }

        public Usuario usuarioLogueado { get; set; }

        public DatosSoporte datosSoporte;



        public void opcionRegistrarMantenimientoCorrectivoRT()
        {
            this.usuario = new Usuario("ppai", "ppai");
            this.sesionActual = new Sesion(DateTime.Now, usuario);
            this.datosSoporte = new DatosSoporte();

            pantallaRT = new FormularioSeleccionRT(this);

            disponible = buscarEstadoDisponible();

            asignacionResponsableTecnico = buscarAsginacionResponsable(sesionActual.getUsuario());

            recursoTecnologicos = buscarRTDisponibles(asignacionResponsableTecnico, disponible);

            pantallaRT.solicitarSeleccionRT(recursoTecnologicos);
            pantallaRT.Show();
            //recursoSeleccionado = enviarASolicitarSeleccion(recursoTecnologicos);
        }

        private Estado buscarEstadoDisponible()
        {
            return datosSoporte.getEstadoDisponibleRecursoTecnologico();
        }
        
        private AsignacionResponsableTecnicoRT buscarAsginacionResponsable(Usuario usuario)
        {
            DateTime fechaActual = DateTime.Now;

            PersonalCientifico personalCientifico = new PersonalCientifico(82387, "Juan", "juan@gmail.com", "juan@gmail.com", usuario);

            disponible = buscarEstadoDisponible();

            CambioEstadoRT cambioEstadoRT = new CambioEstadoRT(new DateTime(2022, 6, 5), null, disponible);
            
            RecursoTecnologico recurso1 = new RecursoTecnologico(1, null, null, null);
            
            recurso1.agregarCambioEstado(cambioEstadoRT);

            List<RecursoTecnologico> recursos = new List<RecursoTecnologico>();
            recursos.Add(recurso1);

            AsignacionResponsableTecnicoRT asignacionResponsableTecnicoRT = new AsignacionResponsableTecnicoRT(DateTime.Now, personalCientifico, recursos);
           

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
