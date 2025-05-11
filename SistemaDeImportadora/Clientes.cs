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
    public partial class Clientes : UserControl
    {
        private Datos_Cliente cliente = new Datos_Cliente();
        private DataTable table = new DataTable();
        public Clientes()
        {
            InitializeComponent();
            Iniciar();
            Consultar();
            dataGridView1.DataSource = table;
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            eliminar2ToolStripMenuItem1.Click += eliminar2ToolStripMenuItem1_Click;

            txtBuscarC.TextChanged += txtBuscarC_TextChanged;
        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioClientes formularioClientes = new FormularioClientes(cliente);
            formularioClientes.ShowDialog();
            Consultar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
        public void Iniciar()
        {
            table = new DataTable();
            table.Columns.Add("ID Cliente");
            table.Columns.Add("Nombre");
            table.Columns.Add("Teléfono");
            table.Columns.Add("Correo");
        }
        public void Consultar()
        {
            table.Rows.Clear();
            foreach (var i in cliente.ConsultarC())
            {
                DataRow fila = table.NewRow();
                fila["ID Cliente"] = i.ID;
                fila["Nombre"] = i.Nombre;
                fila["Teléfono"] = i.Telefono;
                fila["Correo"] = i.Correo;
                table.Rows.Add(fila);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                cliente.EliminarC(nombre);
                Consultar();
                dataGridView1.DataSource = table;
                txtBuscarC_TextChanged(null, null);
            }
        }

        private void eliminar2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string nombre = dataGridView2.SelectedRows[0].Cells["Nombre"].Value.ToString();
                cliente.EliminarC(nombre);
                Consultar();
                dataGridView2.DataSource = table;
                txtBuscarC_TextChanged(null, null);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtBuscarC_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscarC.Text.Trim().ToLower();
            
            if (string.IsNullOrEmpty(criterio) )
            {
                dataGridView2.DataSource = null;
                return;
            }
            DataTable data = table.Clone();

            foreach (DataRow row in table.Rows)
            {
                if (row["Nombre"].ToString().ToLower().Contains(criterio) || row["ID Cliente"].ToString().ToLower().Contains(criterio)) 
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
