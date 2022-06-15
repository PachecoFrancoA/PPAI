using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class DatosSoporte
    {
        public List<Estado> estados;
        
        public List<TipoRT> tiposRT;

        public List<RecursoTecnologico> recursos ;

        public List<Marca> marcas ;

        public List<Modelo> modelos ;

        public DatosSoporte()
        {
            estados = new List<Estado>();
            tiposRT = new List<TipoRT>();
            recursos = new List<RecursoTecnologico>();
            marcas = new List<Marca>();
            modelos = new List<Modelo>();

            estados.Add(new Estado("Disponible", "Recurso Tecnologico"));

        }

        public Estado getEstadoDisponibleRecursoTecnologico()
        {
            foreach(Estado estado in this.estados)
            {
                if (estado.sosDisponibleDeRecursoTecnologico())
                {
                    return estado;
                }
            }
            return null;
        }
    }
}
