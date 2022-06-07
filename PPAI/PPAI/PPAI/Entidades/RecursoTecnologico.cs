using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class RecursoTecnologico
    {

        // hacer un metodo para que se ordenen solos segun el tipo de recurso
        public int numeroRT { get; set; }
        public DateTime? fechaAlta { get; set; }
        public TipoRT tipoRT { get; set; }
        public Modelo modelo { get; set; }

        public List<CambioEstadoRT> cambiosEstado = new List<CambioEstadoRT>();

        public int getNumero()
        {
            return this.numeroRT;
        }
        public String getTipoRT()
        {
            return this.tipoRT.getNombre();
        }
        public String getMarca()
        {
            //Me devuelve el puntero Marca
            return modelo.getMarca();
        }
        public String getModelo()
        {
            //Me devuelve el puntero para el Modelo
            return this.modelo.getNombre();
        }

        public Boolean estaDisponible(Estado disponible)
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

        

       
    }
}
