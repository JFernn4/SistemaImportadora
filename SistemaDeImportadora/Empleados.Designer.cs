namespace SistemaDeImportadora
{
    partial class Empleados
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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            RegistrarVenta = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 20;
            label1.Text = "Lista de Empleados";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(628, 228);
            button2.Name = "button2";
            button2.Size = new Size(198, 37);
            button2.TabIndex = 22;
            button2.Text = "Eliminar Empleado";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(628, 156);
            button1.Name = "button1";
            button1.Size = new Size(198, 37);
            button1.TabIndex = 19;
            button1.Text = "Buscar Empleado";
            button1.UseVisualStyleBackColor = false;
            // 
            // RegistrarVenta
            // 
            RegistrarVenta.BackColor = Color.FromArgb(0, 0, 64);
            RegistrarVenta.Cursor = Cursors.Hand;
            RegistrarVenta.FlatStyle = FlatStyle.Flat;
            RegistrarVenta.Font = new Font("Century Gothic", 12F);
            RegistrarVenta.ForeColor = Color.White;
            RegistrarVenta.Location = new Point(628, 84);
            RegistrarVenta.Name = "RegistrarVenta";
            RegistrarVenta.Size = new Size(198, 37);
            RegistrarVenta.TabIndex = 18;
            RegistrarVenta.Text = "Registrar Empleado";
            RegistrarVenta.UseVisualStyleBackColor = false;
            RegistrarVenta.Click += RegistrarVenta_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(598, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 389);
            panel1.TabIndex = 21;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RegistrarVenta);
            Controls.Add(panel1);
            Name = "Empleados";
            Size = new Size(853, 389);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label label1;
        private Button button2;
        private Button button1;
        private Button RegistrarVenta;
        private Panel panel1;
    }
}
