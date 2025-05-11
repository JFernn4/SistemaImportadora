namespace SistemaDeImportadora
{
    partial class Vehiculos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            RegistrarVenta = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtBuscarVe = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            eliminar2ToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(53, 59);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 21;
            label1.Text = "Lista de Vehículos";
            // 
            // RegistrarVenta
            // 
            RegistrarVenta.BackColor = Color.FromArgb(0, 0, 64);
            RegistrarVenta.Cursor = Cursors.Hand;
            RegistrarVenta.FlatStyle = FlatStyle.Flat;
            RegistrarVenta.Font = new Font("Century Gothic", 12F);
            RegistrarVenta.ForeColor = Color.White;
            RegistrarVenta.Location = new Point(36, 125);
            RegistrarVenta.Margin = new Padding(3, 4, 3, 4);
            RegistrarVenta.Name = "RegistrarVenta";
            RegistrarVenta.Size = new Size(226, 49);
            RegistrarVenta.TabIndex = 22;
            RegistrarVenta.Text = "Registrar Vehículo";
            RegistrarVenta.UseVisualStyleBackColor = false;
            RegistrarVenta.Click += RegistrarVenta_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBuscarVe);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(RegistrarVenta);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(684, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 519);
            panel1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 240);
            label3.Name = "label3";
            label3.Size = new Size(260, 20);
            label3.TabIndex = 26;
            label3.Text = "Ingrese la marca, año, modelo o color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 205);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 25;
            label2.Text = "BUSCAR";
            // 
            // txtBuscarVe
            // 
            txtBuscarVe.Location = new Point(81, 202);
            txtBuscarVe.Name = "txtBuscarVe";
            txtBuscarVe.Size = new Size(196, 27);
            txtBuscarVe.TabIndex = 24;
            txtBuscarVe.TextChanged += txtBuscarVe_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(14, 271);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(263, 193);
            dataGridView2.TabIndex = 23;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.ContextMenuStripChanged += eliminar2ToolStripMenuItem1_Click;
            dataGridView2.MouseDown += dataGridView2_MouseDown;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(613, 339);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.ContextMenuStripChanged += eliminarToolStripMenuItem_Click;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 28);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(132, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { eliminar2ToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(133, 28);
            // 
            // eliminar2ToolStripMenuItem1
            // 
            eliminar2ToolStripMenuItem1.Name = "eliminar2ToolStripMenuItem1";
            eliminar2ToolStripMenuItem1.Size = new Size(132, 24);
            eliminar2ToolStripMenuItem1.Text = "Eliminar";
            eliminar2ToolStripMenuItem1.Click += eliminar2ToolStripMenuItem1_Click;
            // 
            // Vehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Vehiculos";
            Size = new Size(975, 519);
            Load += Vehiculos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label1;
        private Button RegistrarVenta;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private TextBox txtBuscarVe;
        private DataGridView dataGridView2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem eliminar2ToolStripMenuItem1;
    }
}
