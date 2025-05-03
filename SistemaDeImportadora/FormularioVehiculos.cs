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
    public partial class FormularioVehiculos : Form
    {
        Datos_Vehiculo datosvehiculo = new Datos_Vehiculo();
        public FormularioVehiculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormularioVehiculos_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            R_Vehiculo r_Vehiculo = new R_Vehiculo
            {
                ID = int.Parse(textBox1.Text),
                Marca = comboBox2.Text,
                Modelo = textBox2.Text,
                Precio = double.Parse(textBox5.Text),
                Color = comboBox3.Text,
                DateTime = DateTime.Parse(textBox3.Text)
            };
            datosvehiculo.GuardarVe(r_Vehiculo);
        }
    }
}
