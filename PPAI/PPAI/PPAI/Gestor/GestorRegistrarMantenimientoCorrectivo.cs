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
        public List<RecursoTecnologico> recursosTecnologicosDisponibles { get; set; }
        public RecursoTecnologico recursoSeleccionado { get; set; }
        public Estado disponible { get; set; }

        public Usuario usuarioLogueado { get; set; }

        public DatosSoporte datosSoporte;

        public DatosNegocio datosNegocio;

        public FrmFechaFin frmFechaFin;

        public DateTime? fechaFinPrevista;

        public string motivo;

        public FrmTurnos frmTurnos;

        public FrmConfirmacionDatos frmConfirmacionDatos;

        public List<Turno> turnosConfirmadosOPdteConfirmacion;


        public void opcionRegistrarMantenimientoCorrectivoRT()
        {
            pantallaRT = new FormularioSeleccionRT(this);

            this.datosSoporte = new DatosSoporte();
            this.datosNegocio = new DatosNegocio(datosSoporte);

            this.sesionActual = datosNegocio.getSesionActual();
            this.usuario = datosNegocio.getUsuarioLogueado(sesionActual);

            recursosTecnologicosDisponibles = buscarRTDisponibles(this.usuario);

            agruparPorTipoDeRecurso(recursosTecnologicosDisponibles);

            pantallaRT.solicitarSeleccionRT(recursosTecnologicosDisponibles);

            pantallaRT.Show();
            //recursoSeleccionado = enviarASolicitarSeleccion(recursoTecnologicos);

        }


        private List<RecursoTecnologico> buscarRTDisponibles(Usuario usuario)
        {

            return datosNegocio.getRecursosTecnologicosDisponibles(usuario);

        }

        private void agruparPorTipoDeRecurso(List<RecursoTecnologico> recursosTecnologicosDisponibles)
        {
            //ordenamiento
            recursosTecnologicosDisponibles.Sort((x, y) => x.getTipoRT().compareTo(y.getTipoRT()));
        }

        public void tomarSeleccionRT(int numeroRTSeleccionado)
        {
            foreach (RecursoTecnologico recursoTecnologico in this.recursosTecnologicosDisponibles)
            {
                if (recursoTecnologico.esTuNumero(numeroRTSeleccionado))
                {
                    this.recursoSeleccionado = recursoTecnologico;
                }
            }

            // reordenar
            solicitarFechaFinPrevista();

        }

        public void solicitarFechaFinPrevista()
        {
            frmFechaFin = new FrmFechaFin(this);
            frmFechaFin.Show();

        }

        public void tomarFechaFinPrevistaYMotivo(Tuple<DateTime?, string> tupla)
        {
            this.fechaFinPrevista = tupla.Item1;
            this.motivo = tupla.Item2;

            buscarReservaTurno((DateTime) fechaFinPrevista);
        }

        public void buscarReservaTurno(DateTime fechaFinPrevista)
        {
            frmTurnos = new FrmTurnos(this);
            Estado estadoPdteConfirmacionTurno = datosSoporte.getEstadoPdteConfirmacionTurno();
            Estado estadoConfirmado = datosSoporte.getEstadoConfirmadoTurno();

            turnosConfirmadosOPdteConfirmacion = recursoSeleccionado.buscarTurnosConfOPdteConf(fechaFinPrevista, estadoPdteConfirmacionTurno, estadoConfirmado);

            agruparPorPersonalCientifico(turnosConfirmadosOPdteConfirmacion);

            frmTurnos.solicitarConfirmacionAMantenimiento(turnosConfirmadosOPdteConfirmacion);
            frmTurnos.Show();


        }

        private void agruparPorPersonalCientifico(List<Turno> turnosConfirmadosOPdteConfirmacion)
        {
            //ordenamiento
            turnosConfirmadosOPdteConfirmacion.Sort((x, y) => x.compareTo(y));
        }

        // el motivo no se usa en este metodo
        public void tomarConfirmacion()
        {
            frmConfirmacionDatos = new FrmConfirmacionDatos(this);
            frmConfirmacionDatos.solicitarConfirmacionNotificacion(recursoSeleccionado, fechaFinPrevista);
            frmConfirmacionDatos.Show();
        }

        public void tomarConfirmacionIngresoCorrectivo()
        {

            this.crearMantenimientoCorrectivoRT();

            Estado estadoCanceladoPorMC = buscarEstadoCanceladoPorMantenimientCorrectivo();

            Estado estadoConIngresoEnMC = buscarEstadoConIngresoEnMantenimiento();

            this.actualizarEstadoTurnos(estadoCanceladoPorMC);

            this.recursoSeleccionado.agregarCambioEstado(estadoConIngresoEnMC);

            this.generarMail();

        }

        public void actualizarEstadoTurnos(Estado estadoCanceladoPorMC)
        {
            recursoSeleccionado.cancelarTurnos(turnosConfirmadosOPdteConfirmacion, estadoCanceladoPorMC);
        }

        public void crearMantenimientoCorrectivoRT()
        {
            recursoSeleccionado.crearMantenimientoCorrectivo(fechaFinPrevista, motivo);
        }

        public Estado buscarEstadoCanceladoPorMantenimientCorrectivo()
        {
            Estado estadoCanceladoPorMC = datosSoporte.getEstadoCanceladoPorMC();
            return estadoCanceladoPorMC;
        }

        public Estado buscarEstadoConIngresoEnMantenimiento()
        {
            Estado estadoConIngresoEnMantenimiento = datosSoporte.getEstadoConIngresoEnMC();
            return estadoConIngresoEnMantenimiento;
        }

        public void generarMail()
        {
            //hacer frm que diga enviando mail
        }
        
       



        //private Estado buscarEstadoDisponible()
        //{
        //    return datosSoporte.getEstadoDisponibleRecursoTecnologico();
        //}

        //private AsignacionResponsableTecnicoRT buscarAsginacionResponsable(Usuario usuario)
        //{

        //    PersonalCientifico personalCientifico = datosNegocio.getPersonalCientificoUsuario(usuario);

        //    disponible = buscarEstadoDisponible();

        //    CambioEstadoRT cambioEstadoRT = new CambioEstadoRT(new DateTime(2022, 6, 5), null, disponible);

        //    RecursoTecnologico recurso1 = new RecursoTecnologico(1, null, null, null);

        //    recurso1.agregarCambioEstado(cambioEstadoRT);

        //    List<RecursoTecnologico> recursos = new List<RecursoTecnologico>();
        //    recursos.Add(recurso1);

        //    AsignacionResponsableTecnicoRT asignacionResponsableTecnicoRT = new AsignacionResponsableTecnicoRT(DateTime.Now, personalCientifico, recursos);


        //    List<AsignacionResponsableTecnicoRT> asignaciones = new List<AsignacionResponsableTecnicoRT>();
        //    asignaciones.Add(asignacionResponsableTecnicoRT);

        //    foreach (AsignacionResponsableTecnicoRT asignacion in asignaciones)
        //    {
        //        if ((asignacion.esTuUsuario(usuario)))
        //        {
        //            return asignacion;
        //        }
        //        //&& asignacion.esActual()
        //    }
        //    return null;

        //}
        //private List<RecursoTecnologico> buscarRTDisponibles(AsignacionResponsableTecnicoRT asignacion, Estado disponible)
        //{
        //    return asignacion.misRTDisponibles(disponible);
        //    //return asignacion.mostrarRecursos();

        //}
    }
}
