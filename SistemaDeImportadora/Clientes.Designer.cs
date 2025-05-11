namespace SistemaDeImportadora
{
    partial class Clientes
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
            dataGridView1 = new DataGridView();
            txtBuscarC = new TextBox();
            dataGridView2 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            eliminar2ToolStripMenuItem1 = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            label1.Size = new Size(87, 23);
            label1.TabIndex = 16;
            label1.Text = "Clientes";
            // 
            // RegistrarVenta
            // 
            RegistrarVenta.BackColor = Color.FromArgb(0, 0, 64);
            RegistrarVenta.Cursor = Cursors.Hand;
            RegistrarVenta.FlatStyle = FlatStyle.Flat;
            RegistrarVenta.Font = new Font("Century Gothic", 12F);
            RegistrarVenta.ForeColor = Color.White;
            RegistrarVenta.Location = new Point(718, 145);
            RegistrarVenta.Margin = new Padding(3, 4, 3, 4);
            RegistrarVenta.Name = "RegistrarVenta";
            RegistrarVenta.Size = new Size(226, 49);
            RegistrarVenta.TabIndex = 17;
            RegistrarVenta.Text = "Registrar Cliente";
            RegistrarVenta.UseVisualStyleBackColor = false;
            RegistrarVenta.Click += RegistrarVenta_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(638, 341);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView2_CellContentClick;
            dataGridView1.ContextMenuStripChanged += eliminarToolStripMenuItem_Click;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // txtBuscarC
            // 
            txtBuscarC.Location = new Point(787, 216);
            txtBuscarC.Name = "txtBuscarC";
            txtBuscarC.Size = new Size(157, 27);
            txtBuscarC.TabIndex = 19;
            txtBuscarC.TextChanged += txtBuscarC_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(718, 277);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(226, 209);
            dataGridView2.TabIndex = 20;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.MouseDown += dataGridView2_MouseDown;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(718, 246);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 21;
            label2.Text = "Ingrese el nombre o el ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(718, 223);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 22;
            label3.Text = "BUSCAR";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(txtBuscarC);
            Controls.Add(dataGridView1);
            Controls.Add(RegistrarVenta);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Clientes";
            Size = new Size(975, 519);
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label1;
        private Button RegistrarVenta;
        private DataGridView dataGridView1;
        private TextBox txtBuscarC;
        private DataGridView dataGridView2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem eliminar2ToolStripMenuItem1;
        private Label label2;
        private Label label3;
    }
}
