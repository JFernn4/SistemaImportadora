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
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioClientes formularioClientes = new FormularioClientes();
            formularioClientes.Show();
        }
    }
}
