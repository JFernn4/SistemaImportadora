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
    public partial class FormularioVentas : Form
    {
        Datos_Venta datosventa = new Datos_Venta();
        public FormularioVentas()
        {
            InitializeComponent();
        }

        private void FormularioVentas_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            R_Venta r_Venta = new R_Venta()
            {
                ID = int.Parse(textBox1.Text),
                ID_Cliente = int.Parse(comboBox2.Text),
                ID_Vehiculo = int.Parse(comboBox3.Text),
                ID_Empleado = int.Parse(comboBox4.Text),
                Datetime = DateTime.Parse(textBox7.Text),
                Metodo_Pago = comboBox5.Text,
                Pago = double.Parse(textBox6.Text),
                Monto = double.Parse(textBox2.Text),
                Pendiente = double.Parse(textBox3.Text)
            };
            datosventa.GuardarV(r_Venta);
        }
    }
}
