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

        

        public List<Marca> marcas ;

        public List<Modelo> modelos ;

        public DatosSoporte()
        {
            // Estados
            estados = new List<Estado>();
            estados.Add(new Estado("Disponible", "RecursoTecnologico"));

            estados.Add(new Estado("Confirmado", "Turno"));
            estados.Add(new Estado("PendienteConfirmacion", "Turno"));

            //Tipos RT
            tiposRT = new List<TipoRT>();
            TipoRT tipo1 = new TipoRT("Herramientas", "Herramientas");
            tiposRT.Add(tipo1);


            //Marcas
            marcas = new List<Marca>();
            Marca marca1 = new Marca("Steel");
            marcas.Add(marca1);
            
            //Modelos
            modelos = new List<Modelo>();
            Modelo modelo1 = new Modelo("Bokan", marca1);
            modelos.Add(modelo1);
            
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

        public Estado getEstadoPdteConfirmacionTurno()
        {
            foreach (Estado estado in this.estados)
            {
                if (estado.sosPdteConfirmacionTurno())
                {
                    return estado;
                }
            }
            return null;
        }
        
        public Estado getEstadoConfirmadoTurno()
        {
            foreach (Estado estado in this.estados)
            {
                if (estado.sosConfirmado())
                {
                    return estado;
                }
            }
            return null;
        }
    }
}
