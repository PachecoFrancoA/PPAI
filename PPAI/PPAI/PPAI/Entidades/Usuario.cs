using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Usuario
    {
        private string password { get; set; }
        private string usuario { get; set; }

        public Usuario(string password, string usuario)
        {
            this.password = password;
            this.usuario = usuario;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }
        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public string getUsuario()
        {
            return this.usuario;
        }
        //public PersonalCientifico personalCientifico { get; set; }
        //public bool habilitado { get; set; }
        //probando
    }
}