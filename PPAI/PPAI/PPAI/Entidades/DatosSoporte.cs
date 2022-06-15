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
            TipoRT tipo2 = new TipoRT("Balanza de precision", "Balanza de precision");
            tiposRT.Add(tipo2);
            TipoRT tipo3 = new TipoRT("Microscopio", "Microscopio");
            tiposRT.Add(tipo3);
            TipoRT tipo4 = new TipoRT("Resonador magnetico", "Resonador magnetico");
            tiposRT.Add(tipo4);
            TipoRT tipo5 = new TipoRT("Computo", "Computo");
            tiposRT.Add(tipo5);
            TipoRT tipo6 = new TipoRT("Camara", "Camara");
            tiposRT.Add(tipo6);


            //Marcas
            marcas = new List<Marca>();
            Marca marca1 = new Marca("Steel");
            marcas.Add(marca1);
            Marca marca2 = new Marca("Nikon");
            marcas.Add(marca2);
            Marca marca3 = new Marca("Philips");
            marcas.Add(marca3);
            Marca marca4 = new Marca("Sony");
            marcas.Add(marca4);
            Marca marca5 = new Marca("Samsung");
            marcas.Add(marca5);
            Marca marca6 = new Marca("Brother");
            marcas.Add(marca6);
            Marca marca7 = new Marca("Hp");
            marcas.Add(marca7);
            Marca marca8 = new Marca("Cannon");
            marcas.Add(marca8);
            Marca marca9 = new Marca("Kern");
            marcas.Add(marca9);
            Marca marca10 = new Marca("Leica");
            marcas.Add(marca10);

            //Modelos
            modelos = new List<Modelo>();
            Modelo modelo1 = new Modelo("Bokan", marca1);
            modelos.Add(modelo1);
            Modelo modelo2 = new Modelo("MM-400/800", marca3);
            modelos.Add(modelo2);
            Modelo modelo3 = new Modelo("TXB622L", marca2);
            modelos.Add(modelo3);
            Modelo modelo4 = new Modelo("FH - 100", marca7);
            modelos.Add(modelo4);
            Modelo modelo5 = new Modelo("S2", marca9);
            modelos.Add(modelo5);
            Modelo modelo6 = new Modelo("PROVIEW", marca4);
            modelos.Add(modelo6);
            Modelo modelo7 = new Modelo("Vista 1.0T", marca5);
            modelos.Add(modelo7);
            Modelo modelo8 = new Modelo("EZ4", marca10);
            modelos.Add(modelo8);
            Modelo modelo9 = new Modelo("Groscan NT 0.5T", marca6);
            modelos.Add(modelo9);
            Modelo modelo10 = new Modelo("ADB - 27", marca5);
            modelos.Add(modelo10);


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
