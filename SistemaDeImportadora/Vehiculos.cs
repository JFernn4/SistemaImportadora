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
    public partial class Vehiculos : UserControl
    {
        private Datos_Vehiculo datosvehiculo = new Datos_Vehiculo();
        private DataTable table = new DataTable();
        public Vehiculos()
        {
            InitializeComponent();
            Iniciar();
            Consultar();
            dataGridView1.DataSource = table;
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            eliminar2ToolStripMenuItem1.Click += eliminar2ToolStripMenuItem1_Click;

            txtBuscarVe.TextChanged += txtBuscarVe_TextChanged;
        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioVehiculos formularioVehiculos = new FormularioVehiculos(datosvehiculo);
            formularioVehiculos.ShowDialog();
            Consultar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {

        }
        public void Iniciar()
        {
            table = new DataTable();
            table.Columns.Add("ID Vehiculo");
            table.Columns.Add("Marca");
            table.Columns.Add("Modelo");
            table.Columns.Add("Precio");
            table.Columns.Add("Color");
            table.Columns.Add("Año");
            table.Columns.Add("Matrícula");
        }
        public void Consultar()
        {
            table.Rows.Clear();
            foreach (var i in datosvehiculo.ConsultarVe())
            {
                DataRow fila = table.NewRow();
                fila["ID Vehiculo"] = i.ID;
                fila["Marca"] = i.Marca;
                fila["Modelo"] = i.Modelo;
                fila["Precio"] = i.Precio;
                fila["Color"] = i.Color;
                fila["Año"] = i.Año;
                fila["Matrícula"] = i.Matricula;
                table.Rows.Add(fila);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string marca = dataGridView1.SelectedRows[0].Cells["Marca"].Value.ToString();
                datosvehiculo.EliminarVe(marca);
                Consultar();
                dataGridView1.DataSource = table;
                txtBuscarVe_TextChanged(null, null);
            }
        }

        private void eliminar2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string marca = dataGridView2.SelectedRows[0].Cells["Marca"].Value.ToString();
                datosvehiculo.EliminarVe(marca);
                Consultar();
                dataGridView2.DataSource = table;
                txtBuscarVe_TextChanged(null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtBuscarVe_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscarVe.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(criterio))
            {
                dataGridView2.DataSource = null;
                return;
            }
            DataTable data = table.Clone();

            foreach (DataRow row in table.Rows)
            {
                if (row["Marca"].ToString().ToLower().Contains(criterio) || row["ID Vehiculo"].ToString().ToLower().Contains(criterio) || row["Color"].ToString().ToLower().Contains(criterio) || row["Modelo"].ToString().ToLower().Contains(criterio) || row["Año"].ToString().ToLower().Contains(criterio))
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
