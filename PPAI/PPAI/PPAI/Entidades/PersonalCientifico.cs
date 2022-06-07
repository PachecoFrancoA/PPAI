using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class PersonalCientifico
    {
        public int legajo { get; set; }
        public string nombre { get; set; }
        //public string apellido { get; set; }
        //public int nro_doc { get; set; }
        public string correo_inst { get; set; }
        public string correo_pers { get; set; }
        //public int telefono { get; set; }
        public Usuario usuario { get; set; }

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
