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
    public partial class Vehiculos : UserControl
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioVehiculos formularioVehiculos = new FormularioVehiculos();
            formularioVehiculos.Show();
        }
    }
}
