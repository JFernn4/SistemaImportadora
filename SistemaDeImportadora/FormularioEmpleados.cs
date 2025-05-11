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
    public partial class FormularioEmpleados : Form
    {
        private Datos_Empleado datosempleado = new Datos_Empleado();
        public FormularioEmpleados(Datos_Empleado datosempleado)
        {
            InitializeComponent();
            this.datosempleado = datosempleado;
        }

        private void FormularioEmpleados_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(comboBox2.Text))
                {
                    MessageBox.Show("Complete todos los datos");
                    return;
                }
                if (!int.TryParse(textBox2.Text, out int id1))
                {
                    MessageBox.Show("Ingrese un ID valido");
                    return;
                }
                if (!double.TryParse(textBox4.Text, out double salario))
                {
                    MessageBox.Show("Ingrese un salario valido");
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
            R_Empleado r_Empleado = new R_Empleado()
            {
                ID = int.Parse(textBox2.Text),
                Nombre = textBox1.Text,
                Telefono = textBox5.Text,
                Cargo = comboBox2.Text,
                Correo = textBox3.Text,
                Salario = double.Parse(textBox4.Text)
            };
            datosempleado.Guardar(r_Empleado);
        }
        public void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
