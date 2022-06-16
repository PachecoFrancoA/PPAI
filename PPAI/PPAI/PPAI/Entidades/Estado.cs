namespace PPAI.Entidades
{
    public class Estado
    {


        private string nombre { get; set; }
        private string ambito { get; set; }

        public Estado(string nombre, string ambito)
        {
            this.nombre = nombre;
            this.ambito = ambito;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public void setAmbito(string ambito)
        {
            this.ambito = ambito;
        }

        public string getAmbito()
        {
            return this.ambito;
        }

        public bool sosDisponibleDeRecursoTecnologico()
        {
            if (nombre.Equals("Disponible") && ambito.Equals("RecursoTecnologico"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosPdteConfirmacionTurno()
        {
            if (nombre.Equals("PendienteConfirmacion") && ambito.Equals("Turno"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosConfirmado()
        {
            if (nombre.Equals("Confirmado") && ambito.Equals("Turno"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosCanceladoPorMCTurno()
        {
            if (nombre.Equals("CanceladoPorMC") && ambito.Equals("Turno"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosConIngresoEnMCRecursoTecnologico()
        {
            if (nombre.Equals("ConIngresoEnMC") && ambito.Equals("RecursoTecnologico"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    
}
