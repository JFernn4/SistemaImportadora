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
        Datos_Empleado datosempleado = new Datos_Empleado();
        public FormularioEmpleados()
        {
            InitializeComponent();
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
            Guardar();
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
                Salario = double.Parse(maskedTextBox1.Text)
            };
            datosempleado.Guardar(r_Empleado);
        }
    }
}
