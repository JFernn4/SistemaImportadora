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
    public partial class FormularioClientes : Form
    {
        Datos_Cliente datoscliente = new Datos_Cliente();
        public FormularioClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            R_Cliente cliente = new R_Cliente()
            {
                ID = int.Parse(textBox2.Text),
                Nombre = textBox1.Text,
                Telefono = maskedTextBox1.Text,
                Correo = textBox3.Text
            };
            datoscliente.GuardarC(cliente);
        }
        private void Cancelar()
        {
            textBox2.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox3.Text = "";
        }
    }
}
