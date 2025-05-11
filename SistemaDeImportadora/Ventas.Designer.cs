namespace SistemaDeImportadora
{
    partial class Ventas
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
            RegistrarVenta = new Button();
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            txtBuscarV = new TextBox();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            eliminar2ToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrarVenta
            // 
            RegistrarVenta.BackColor = Color.FromArgb(0, 0, 64);
            RegistrarVenta.Cursor = Cursors.Hand;
            RegistrarVenta.FlatStyle = FlatStyle.Flat;
            RegistrarVenta.Font = new Font("Century Gothic", 12F);
            RegistrarVenta.ForeColor = Color.White;
            RegistrarVenta.Location = new Point(34, 129);
            RegistrarVenta.Margin = new Padding(3, 4, 3, 4);
            RegistrarVenta.Name = "RegistrarVenta";
            RegistrarVenta.Size = new Size(226, 49);
            RegistrarVenta.TabIndex = 0;
            RegistrarVenta.Text = "Registrar Venta";
            RegistrarVenta.UseVisualStyleBackColor = false;
            RegistrarVenta.Click += RegistrarVenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(53, 59);
            label1.Name = "label1";
            label1.Size = new Size(191, 23);
            label1.TabIndex = 15;
            label1.Text = "Historial de Ventas";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBuscarV);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(RegistrarVenta);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(684, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 519);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(611, 338);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.ContextMenuStripChanged += eliminarToolStripMenuItem_Click;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(14, 263);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(263, 204);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.ContextMenuStripChanged += eliminar2ToolStripMenuItem1_Click;
            dataGridView2.MouseDown += dataGridView2_MouseDown;
            // 
            // txtBuscarV
            // 
            txtBuscarV.Location = new Point(88, 200);
            txtBuscarV.Name = "txtBuscarV";
            txtBuscarV.Size = new Size(189, 27);
            txtBuscarV.TabIndex = 2;
            txtBuscarV.TextChanged += txtBuscarV_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 203);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "BUSCAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 240);
            label3.Name = "label3";
            label3.Size = new Size(220, 20);
            label3.TabIndex = 4;
            label3.Text = "ingrese el id o la fecha de venta";
            label3.Click += label3_Click;
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
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            Size = new Size(975, 519);
            Load += Ventas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistrarVenta;
        protected Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private TextBox txtBuscarV;
        private DataGridView dataGridView2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem eliminar2ToolStripMenuItem1;
    }
}
