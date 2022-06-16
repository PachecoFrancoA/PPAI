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
    public partial class FrmVisulizarCambios : Form
    {

        private GestorRegistrarMantenimientoCorrectivo gestor;

        public FrmVisulizarCambios(GestorRegistrarMantenimientoCorrectivo _gestor)
        {
            this.gestor = _gestor;
            InitializeComponent();
        }

        public void finCU(RecursoTecnologico seleccionado, List<Turno> turnosCancelados)
        {
            cargarGrilla(seleccionado, turnosCancelados);

        }

        public void cargarGrilla(RecursoTecnologico seleccionado, List<Turno> turnosCancelados)
        {
            grid11.Formatear("Fecha, 50, C; Hora, 50, C; Cientifico, 50, C; Mail Cientifico, 100, C; Estado, 50, C");
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

            //creo columna estado
            column = new DataColumn();
            column.ColumnName = "Estado";
            tablaTurnos.Columns.Add(column);

            foreach (Turno t in turnosCancelados)
            {
                //falta asignar los otros valores en el hardcodeo
                row = tablaTurnos.NewRow();
                row["Fecha"] = t.getFechaHoraInicio().Date;
                row["Hora"] = t.getFechaHoraInicio().TimeOfDay;
                row["Cientifico"] = t.getAsignacionCientificoCI().getPersonalCientifico().getNombre();
                row["Mail Cientifico"] = t.getAsignacionCientificoCI().getPersonalCientifico().getCorreo_inst();
                row["Estado"] = t.getEstado().getNombre();
                tablaTurnos.Rows.Add(row);
            }

            grid11.Cargar(tablaTurnos);

            // tabla recurso

            grid12.Formatear("Numero, 50, C; Tipo de RT, 100, C; Marca, 75, C; Modelo, 75, C; Estado, 50, C");
            DataTable tablaRecursos = new DataTable();

            //creo columna numero
            column = new DataColumn();
            column.ColumnName = "Numero";
            tablaRecursos.Columns.Add(column);

            //creo columna Tipo
            column = new DataColumn();
            column.ColumnName = "Tipo";
            tablaRecursos.Columns.Add(column);

            //creo columna Marca
            column = new DataColumn();
            column.ColumnName = "Marca";
            tablaRecursos.Columns.Add(column);

            //creo columna Modelo
            column = new DataColumn();
            column.ColumnName = "Modelo";
            tablaRecursos.Columns.Add(column);

            // creo columna Estado
            column = new DataColumn();
            column.ColumnName = "Estado";
            tablaRecursos.Columns.Add(column);

            //falta asignar los otros valores en el hardcodeo
            row = tablaRecursos.NewRow();
            row["Numero"] = seleccionado.getNumero();
            row["Tipo"] = seleccionado.getTipoRT().getNombre();
            row["Marca"] = seleccionado.getMarca();
            row["Modelo"] = seleccionado.getModelo().getNombre();
            row["Estado"] = seleccionado.getEstado().getNombre();
            tablaRecursos.Rows.Add(row);


            grid12.Cargar(tablaRecursos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enviando Mail...", "Notificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gestor.finCU();
        }
    }
}    
