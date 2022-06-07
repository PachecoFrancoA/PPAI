using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Entidades;
using PPAI.Gestor;

namespace PPAI.Interfaces
{
    public partial class frmMenu : Form
    {
        public GestorRegistrarMantenimientoCorrectivo gestor;
        public frmMenu()
        {
            gestor = new GestorRegistrarMantenimientoCorrectivo(this);
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrarRT_Click(object sender, EventArgs e)
        {
            this.gestor.opcionRegistrarMantenimientoCorrectivoRT();
            this.Show();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
       
}
