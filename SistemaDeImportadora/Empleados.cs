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
    public partial class Empleados : UserControl
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioEmpleados formularioEmpleados = new FormularioEmpleados();
            formularioEmpleados.Show();
        }
    }
}
