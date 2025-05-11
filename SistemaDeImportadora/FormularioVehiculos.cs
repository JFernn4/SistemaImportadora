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
        private Datos_Vehiculo datosvehiculo = new Datos_Vehiculo();
        public FormularioVehiculos(Datos_Vehiculo datosvehiculo)
        {
            InitializeComponent();
            this.datosvehiculo = datosvehiculo;
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
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
                {
                    MessageBox.Show("Complete todos los datos");
                    return;
                }
                if (!int.TryParse(textBox1.Text, out int id1))
                {
                    MessageBox.Show("Ingrese un ID valido");
                    return;
                }
                if (!double.TryParse(textBox5.Text, out double precio))
                {
                    MessageBox.Show("Ingrese un precio valido");
                    return;
                }
                if (!int.TryParse(textBox3.Text, out int año))
                {
                    MessageBox.Show("Ingrese un año valido");
                    return;
                }
                Guardar();
                MessageBox.Show("Datos Guardados");
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error al guardar los datos, intente nuevamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        public void Guardar()
        {
            R_Vehiculo r_Vehiculo = new R_Vehiculo
            {
                ID = int.Parse(textBox1.Text),
                Marca = comboBox2.Text,
                Modelo = textBox2.Text,
                Precio = double.Parse(textBox5.Text),
                Color = textBox4.Text,
                Año = int.Parse(textBox3.Text),
                Matricula = textBox6.Text
            };
            datosvehiculo.GuardarVe(r_Vehiculo);
        }
        public void Limpiar()
        {
            textBox1.Clear();
            comboBox2.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
