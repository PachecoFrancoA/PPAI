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
using PPAI.Interfaces;

namespace PPAI.Interfaces
{
    public partial class FormularioSeleccionRT : Form

        // falta la parte de seleccionar uno y devolverlo al form menu
    {
        private GestorRegistrarMantenimientoCorrectivo gestor;


        public FormularioSeleccionRT(GestorRegistrarMantenimientoCorrectivo _gestor)
        {
            gestor = _gestor;
            //recursosDisponibles = gestor.recursoTecnologicos;
            InitializeComponent();
        }

        private void FormularioSeleccionRT_Load(object sender, EventArgs e)
        {
           
        }

        public void solicitarSeleccionRT (List<RecursoTecnologico> recursoTecnologicos)
        {
            cargarGrilla(recursoTecnologicos);
        }

        private void cargarGrilla(List<RecursoTecnologico> recursos)
        {
            grid11.Formatear("Numero, 50, C; Tipo de RT, 100, C; Marca, 75, C; Modelo, 75, C");
            DataTable tablaRecursos = new DataTable();

            DataColumn column;
            DataRow row;

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

            foreach (RecursoTecnologico r in recursos)
            {
                //falta asignar los otros valores en el hardcodeo
                row = tablaRecursos.NewRow();
                row["Numero"] = r.getNumero();
                row["Tipo"] = r.getTipoRT().getNombre();
                row["Marca"] = r.getMarca();
                row["Modelo"] = r.getModelo().getNombre();
                tablaRecursos.Rows.Add(row);
            }

            grid11.Cargar(tablaRecursos);


            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (grid11.SelectedRows.Count == 1)
            {
                int numeroRT = int.Parse(grid11.SelectedRows[0].Cells[0].Value.ToString());
                gestor.tomarSeleccionRT(numeroRT);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Seleccione un recurso tecnologico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void notificarNoHayRecursos()
        {
            MessageBox.Show("No hay recursos tecnologicos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
