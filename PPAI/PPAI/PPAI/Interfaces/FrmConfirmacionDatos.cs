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
    public partial class FrmConfirmacionDatos : Form
    {

        private GestorRegistrarMantenimientoCorrectivo gestor;

        public FrmConfirmacionDatos(GestorRegistrarMantenimientoCorrectivo _gestor)
        {
            gestor = _gestor;
            InitializeComponent();
        }

        public void solicitarConfirmacionNotificacion(RecursoTecnologico recurso, DateTime? FechaFinPrevista)
        {
            cargarGrilla(recurso, FechaFinPrevista);
        }

        public void cargarGrilla(RecursoTecnologico recurso, DateTime? fechaFinPrevista)
        {
            grid11.Formatear("Numero, 50, C; Tipo de RT, 100, C; Marca, 75, C; Modelo, 75, C ; FechaFin, 100, C");
            DataTable tablaRecursos = new DataTable();

            DataColumn column;
            DataRow row;

            //creo columna numero
            column = new DataColumn();
            column.ColumnName = "Numero";
            tablaRecursos.Columns.Add(column);

            //creo columna Tipo
            column = new DataColumn();
            column.ColumnName = "Tipo de RT";
            tablaRecursos.Columns.Add(column);

            //creo columna Marca
            column = new DataColumn();
            column.ColumnName = "Marca";
            tablaRecursos.Columns.Add(column);

            //creo columna Modelo
            column = new DataColumn();
            column.ColumnName = "Modelo";
            tablaRecursos.Columns.Add(column);

            //creo columna FechaFinPrevista
            column = new DataColumn();
            column.ColumnName = "FechaFinPrev";
            tablaRecursos.Columns.Add(column);

            row = tablaRecursos.NewRow();
            row["Numero"] = recurso.getNumero();
            row["Tipo de RT"] = recurso.getTipoRT().getNombre();
            row["Marca"] = recurso.getMarca();
            row["Modelo"] = recurso.getModelo().getNombre();
            row["FechaFinPrev"] = fechaFinPrevista;
            tablaRecursos.Rows.Add(row);


            grid11.Cargar(tablaRecursos);
        }

        private void FrmConfirmacionDatos_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gestor.tomarConfirmacionIngresoCorrectivo();
            this.Dispose();
        }
    }
}
