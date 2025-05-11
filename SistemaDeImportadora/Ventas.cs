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
    public partial class Ventas : UserControl
    {
        private Datos_Venta datos = new Datos_Venta();
        private DataTable tabla = new DataTable();
        public Ventas()
        {
            InitializeComponent();
            Inicio();
            Consultar();
            dataGridView1.DataSource = tabla;
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            eliminar2ToolStripMenuItem1.Click += eliminar2ToolStripMenuItem1_Click;

            txtBuscarV.TextChanged += txtBuscarV_TextChanged;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioVentas formularioVentas = new FormularioVentas(datos);
            formularioVentas.ShowDialog();
            Consultar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tabla;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void Inicio()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ID Venta");
            tabla.Columns.Add("ID Cliente");
            tabla.Columns.Add("ID Vehículo");
            tabla.Columns.Add("ID Empleado");
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Método de pago");
            tabla.Columns.Add("Monto total");
            tabla.Columns.Add("Pago");
            tabla.Columns.Add("Pendiente");
        }
        public void Consultar()
        {
            tabla.Rows.Clear();
            foreach (var i in datos.ConsultarV())
            {
                DataRow fila = tabla.NewRow();
                fila["ID Venta"] = i.ID;
                fila["ID Cliente"] = i.ID_Cliente;
                fila["ID Vehículo"] = i.ID_Vehiculo;
                fila["ID Empleado"] = i.ID_Empleado;
                fila["Fecha"] = i.Datetime;
                fila["Método de pago"] = i.Metodo_Pago;
                fila["Monto total"] = i.Monto;
                fila["Pago"] = i.Pago;
                fila["Pendiente"] = i.Pendiente;
                tabla.Rows.Add(fila);
            }
        }
        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = dataGridView1.SelectedRows[0].Cells["ID Vehículo"].Value.GetHashCode();
                datos.EliminarV(id);
                Consultar();
                dataGridView1.DataSource = tabla;
                txtBuscarV_TextChanged(null, null);
            }
        }

        private void eliminar2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int id = dataGridView2.SelectedRows[0].Cells["ID Vehículo"].Value.GetHashCode();
                datos.EliminarV(id);
                Consultar();
                dataGridView2.DataSource = tabla;
                txtBuscarV_TextChanged(null, null);
            }

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

        private void txtBuscarV_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBuscarV.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(criterio))
            {
                dataGridView2.DataSource = null;
                return;
            }
            DataTable data = tabla.Clone();

            foreach (DataRow row in tabla.Rows)
            {
                if (row["ID Vehículo"].ToString().ToLower().Contains(criterio) || row["ID Cliente"].ToString().ToLower().Contains(criterio) || row["ID Venta"].ToString().ToLower().Contains(criterio) || row["ID Empleado"].ToString().ToLower().Contains(criterio) || row["Fecha"].ToString().ToLower().Contains(criterio))
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
