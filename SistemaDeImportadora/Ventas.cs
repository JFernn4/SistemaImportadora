﻿using System;
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
        public Ventas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioVentas formularioVentas = new FormularioVentas();
            formularioVentas.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
