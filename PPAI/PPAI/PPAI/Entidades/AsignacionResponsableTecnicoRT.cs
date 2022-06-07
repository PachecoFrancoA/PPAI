using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class AsignacionResponsableTecnicoRT
    {
        public DateTime? fechaDesde { get; set; }
        public DateTime? fechaHasta { get; set; }
        public PersonalCientifico personalCientifico { get; set; }
        public List<RecursoTecnologico> recursoTecnologico { get; set; }


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

        //public List<RecursoTecnologico> mostrarRecursos()
        //{
        //    List<RecursoTecnologico> recursos = new List<RecursoTecnologico>();
        //    foreach (RecursoTecnologico r in this.recursoTecnologico)
        //    {
        //        recursos.Add(r);
        //    }
        //    return recursos;
        //}

    }
}
