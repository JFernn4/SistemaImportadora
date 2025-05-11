using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeImportadora
{
    public partial class Empleados : UserControl
    {
        private Datos_Empleado datosempleado = new Datos_Empleado();
        private DataTable table = new DataTable();
        public Empleados()
        {
            InitializeComponent();
            Inicio();
            Consultar();
            dataGridView1.DataSource = table;
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            eliminar2ToolStripMenuItem1.Click += eliminar2ToolStripMenuItem1_Click;

            txtBuscarE.TextChanged += txtBuscarE_TextChanged;
        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioEmpleados formularioEmpleados = new FormularioEmpleados(datosempleado);
            formularioEmpleados.ShowDialog();
            Consultar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }
        public void Inicio()
        {
            table = new DataTable();
            table.Columns.Add("ID Empleado");
            table.Columns.Add("Nombre");
            table.Columns.Add("Teléfono");
            table.Columns.Add("Cargo");
            table.Columns.Add("Correo");
            table.Columns.Add("Salario");
        }
        public void Consultar()
        {
            table.Rows.Clear();
            foreach (var i in datosempleado.ConsultarE())
            {
                DataRow fila = table.NewRow();
                fila["ID Empleado"] = i.ID;
                fila["Nombre"] = i.Nombre;
                fila["Teléfono"] = i.Telefono;
                fila["Cargo"] = i.Cargo;
                fila["Correo"] = i.Correo;
                fila["Salario"] = i.Salario;
                table.Rows.Add(fila);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                datosempleado.EliminarE(nombre);
                Consultar();
                dataGridView1.DataSource = table;
                txtBuscarE_TextChanged(null, null);
            }
        }

        private void eliminar2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string nombre = dataGridView2.SelectedRows[0].Cells["Nombre"].Value.ToString();
                datosempleado.EliminarE(nombre);
                Consultar();
                dataGridView2.DataSource = table;
                txtBuscarE_TextChanged(null, null);
            }

        }

        private void dataGridView1_CellContenClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView2.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip2.Show(dataGridView2, e.Location);
                }
            }
        }

        private void txtBuscarE_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscarE.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(criterio))
            {
                dataGridView2.DataSource = null;
                return;
            }
            DataTable data = table.Clone();

            foreach (DataRow row in table.Rows)
            {
                if (row["Nombre"].ToString().ToLower().Contains(criterio) || row["ID Empleado"].ToString().ToLower().Contains(criterio))
                {
                    data.ImportRow(row);
                }
            }
            if (data.Rows.Count == 0)
            {
                dataGridView2.DataSource = null;
                MessageBox.Show("No se encontraron esos datos.");
            }
            else
            {
                dataGridView2.DataSource = data;
            }
        }
    }
}
