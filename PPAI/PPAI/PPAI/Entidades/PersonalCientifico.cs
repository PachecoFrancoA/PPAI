using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class PersonalCientifico
    {
        private int legajo { get; set; }
        private string nombre { get; set; }
        //public string apellido { get; set; }
        //public int nro_doc { get; set; }
        private string correo_inst { get; set; }
        private string correo_pers { get; set; }
        //public int telefono { get; set; }
        private Usuario usuario { get; set; }



        public PersonalCientifico(int legajo, string nombre, string correo_inst, string correo_pers, Usuario usuario)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.correo_inst = correo_inst;
            this.correo_pers = correo_pers;
            this.usuario = usuario;
        }

        public PersonalCientifico()
        {
        }

        public void setLegajo(int legajo)
        {
            this.legajo = legajo;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setCorreo_inst(string correo_inst)
        {
            this.correo_inst = correo_inst;
        }

        public string getCorreo_inst()
        {
            return this.correo_inst;
        }

        public void setCorreo_pers(string correo_pers)
        {
            this.correo_pers = correo_pers;
        }

        public string getCorreo_pers()
        {
            return this.correo_pers;
        }

        public void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public Usuario getUsuario()
        {
            return this.usuario;
        }


        public Boolean esTuUsuario(Usuario usuario)
        {
            if (this.usuario == usuario)
            {
                return true;
            }
            return false;
        }
    }
}
