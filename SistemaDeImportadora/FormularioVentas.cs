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
        private Datos_Venta datosventa = new Datos_Venta();
        public FormularioVentas(Datos_Venta datosventa)
        {
            InitializeComponent();
            this.datosventa = datosventa;
            monthCalendar1.Visible = false;
            textBox7.Click += textBox7_Click;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
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
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comboBox3.Text) || string.IsNullOrEmpty(comboBox4.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(comboBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Complete todos los datos");
                    return;
                }
                if (!int.TryParse(textBox1.Text, out int id1))
                {
                    MessageBox.Show("Ingrese un ID valido");
                    return;
                }
                if (!double.TryParse(textBox6.Text, out double pago))
                {
                    MessageBox.Show("Ingrese un pago valido");
                    return;
                }
                if (!double.TryParse(textBox2.Text, out double monto))
                {
                    MessageBox.Show("Ingrese un monto valido");
                    return;
                }
                if (!double.TryParse(textBox3.Text, out double pendiente))
                {
                    MessageBox.Show("Ingrese un monto valido");
                    return;
                }
                Guardar3();
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
        public void Guardar3()
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
        public void Limpiar()
        {
            textBox1.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox7.Clear();
            comboBox5.Text = "";
            textBox6.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox7.Text = e.Start.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            monthCalendar1.Location = new Point(textBox7.Left, textBox7.Bottom + 5);
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
