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
using PPAI.Entidades;


namespace PPAI.Interfaces
{
    public partial class FrmTurnos : Form
    {

        private GestorRegistrarMantenimientoCorrectivo gestor;
        public FrmTurnos(GestorRegistrarMantenimientoCorrectivo _gestor)
        {
            this.gestor = _gestor;
            InitializeComponent();
        }

        public void solicitarConfirmacionAMantenimiento(List<Turno> turnosConfirmadosOPdteConfirmacion)
        {
            cargarGrilla(turnosConfirmadosOPdteConfirmacion);
        }

        public void cargarGrilla(List<Turno> turnosConfirmadosOPdteConfirmacion)
        {
            grid11.Formatear("Fecha, 50, C; Hora, 50, C; Cientifico, 50, C; Mail Cientifico, 100, C");
            DataTable tablaTurnos = new DataTable();

            DataColumn column;
            DataRow row;
            
            //creo columna numero
            column = new DataColumn();
            column.ColumnName = "Fecha";
            tablaTurnos.Columns.Add(column);

            //creo columna Tipo
            column = new DataColumn();
            column.ColumnName = "Hora";
            tablaTurnos.Columns.Add(column);

            //creo columna Marca
            column = new DataColumn();
            column.ColumnName = "Cientifico";
            tablaTurnos.Columns.Add(column);

            //creo columna Modelo
            column = new DataColumn();
            column.ColumnName = "Mail Cientifico";
            tablaTurnos.Columns.Add(column);

            foreach (Turno t in turnosConfirmadosOPdteConfirmacion)
            {
                //falta asignar los otros valores en el hardcodeo
                row = tablaTurnos.NewRow();
                row["Fecha"] = t.getFechaHoraInicio().Date;
                row["Hora"] = t.getFechaHoraInicio().TimeOfDay;
                row["Cientifico"] = t.getAsignacionCientificoCI().getPersonalCientifico().getNombre();
                row["Mail Cientifico"] = t.getAsignacionCientificoCI().getPersonalCientifico().getCorreo_inst();
                tablaTurnos.Rows.Add(row);
            }

            grid11.Cargar(tablaTurnos);
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            this.gestor.tomarConfirmacion();
            this.Dispose();
        }

        public void notificarNoHayTurnos()
        {
            MessageBox.Show("No hay turnos para confirmar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }
    }
}
