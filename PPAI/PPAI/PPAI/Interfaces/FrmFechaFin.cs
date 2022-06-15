using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Gestor;

namespace PPAI.Interfaces
{
    public partial class FrmFechaFin : Form
    {

        private GestorRegistrarMantenimientoCorrectivo gestor;
        
        public FrmFechaFin(GestorRegistrarMantenimientoCorrectivo _gestor)
        {
            gestor = _gestor;
            InitializeComponent();
        }

        private void FrmFechaFin_Load(object sender, EventArgs e)
        {

        }

        public void tomarFechaFinPrevistaYMotivo()
        {
            
            
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            DateTime? fechaFinPrevista = dateTimePicker1.Value;
            string motivo = textBox1.Text;

            Tuple<DateTime?, string> tupla = new Tuple<DateTime?, string>(fechaFinPrevista, motivo);
            gestor.tomarFechaFinPrevistaYMotivo(tupla);
            MessageBox.Show("Fecha de fin prevista: " + fechaFinPrevista + "\nMotivo: " + motivo, "Datos Recolectados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
