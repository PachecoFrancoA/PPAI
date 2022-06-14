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
        private int numeroRT { get; set; }
        private DateTime? fechaAlta { get; set; }

        private TipoRT tipoRT { get; set; }
        private Modelo modelo { get; set; }

        private List<CambioEstadoRT> cambiosEstado = new List<CambioEstadoRT>();

        public int getNumero()
        {
            return this.numeroRT;
        }
        public TipoRT getTipoRT()
        {
            return this.tipoRT;
        }
        public Modelo getModelo()
        {
            return this.modelo;
        }

        public string getMarca()
        {
            return this.modelo.getMarca();
        }


        public void setNumero(int numero)
        {
            this.numeroRT = numero;
        }

        public void setFechaAlta(DateTime? fechaAlta)
        {
            this.fechaAlta = fechaAlta;
        }

        public void setModelo(Modelo modelo)
        {
            this.modelo = modelo;
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