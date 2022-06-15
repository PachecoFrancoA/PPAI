using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class AsignacionResponsableTecnicoRT
    {
        private DateTime? fechaDesde { get; set; }
        private DateTime? fechaHasta { get; set; }
        private PersonalCientifico personalCientifico { get; set; }
        private List<RecursoTecnologico> recursoTecnologico { get; set; }

        public AsignacionResponsableTecnicoRT(DateTime fechaDesde, PersonalCientifico personalCientifico, List<RecursoTecnologico> recursos)
        {
            this.fechaDesde = fechaDesde;
            this.personalCientifico = personalCientifico;
            this.recursoTecnologico = recursos;
        }

        public PersonalCientifico getPersonalCientifico()
        {
            return this.personalCientifico;
        }

        public DateTime? getFechaDesde()
        {
            return this.fechaDesde;
        }
        public DateTime? getFechaHasta()
        {
            return this.fechaHasta;
        }

        public List<RecursoTecnologico> getRecursosTecnologicos()
        {
            return this.recursoTecnologico;
        }


        public void setPersonCienti(PersonalCientifico persCient)
        {
            this.personalCientifico = persCient;
        }

        public void setRT(List<RecursoTecnologico> rt)
        {
            this.recursoTecnologico = rt;

        }

        public void setFechaDesde(DateTime? fechaDesde)
        {
            this.fechaDesde = fechaDesde;
        }

        public void setFechaHasta(DateTime? fechaHasta)
        {
            this.fechaHasta = fechaHasta;
        }




        public Boolean esTuUsuario(Usuario usuario)
        {
            return personalCientifico.esTuUsuario(usuario);
        }

        public Boolean esActual()
        {
            DateTime fechaActual = DateTime.Now;
            if ((fechaDesde <= fechaActual) && (fechaHasta >= fechaActual))
            {
                return true;
            }
            return false;
        }

        public List<RecursoTecnologico> misRTDisponibles(Estado disponible)
        {
            List<RecursoTecnologico> recursos = new List<RecursoTecnologico>();
            foreach (RecursoTecnologico r in this.recursoTecnologico)
            {
                if (r.estaDisponible(disponible))
                {
                    recursos.Add(r);
                }
            }
            return recursos;
        }

        public List<RecursoTecnologico> mostrarRecursos()
        {
            List<RecursoTecnologico> recursos = new List<RecursoTecnologico>();
            foreach (RecursoTecnologico r in this.recursoTecnologico)
            {
                recursos.Add(r);
            }
            return recursos;
        }

    }
}