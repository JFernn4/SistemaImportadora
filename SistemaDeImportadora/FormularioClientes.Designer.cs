namespace SistemaDeImportadora
{
    partial class FormularioClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            btnLimpiar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 13);
            panel2.TabIndex = 95;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(490, 13);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 171);
            panel3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(53, 59);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 96;
            label1.Text = "Registrar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(594, 97);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 97;
            label2.Text = "Detalles del cliente";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(53, 152);
            label10.Name = "label10";
            label10.Size = new Size(162, 23);
            label10.TabIndex = 99;
            label10.Text = "ID Cliente (DPI):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(401, 260);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 116;
            label6.Text = "Correo:";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Century Gothic", 12F);
            textBox3.Location = new Point(485, 259);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 32);
            textBox3.TabIndex = 115;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(53, 260);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 114;
            label5.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(53, 207);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 113;
            label3.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Century Gothic", 12F);
            textBox1.Location = new Point(151, 204);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(622, 32);
            textBox1.TabIndex = 111;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(646, 336);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(128, 49);
            button1.TabIndex = 118;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(495, 336);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(128, 49);
            button2.TabIndex = 117;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(556, 27);
            textBox2.TabIndex = 119;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(151, 260);
            maskedTextBox1.Mask = "0000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(244, 27);
            maskedTextBox1.TabIndex = 120;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(57, 348);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 121;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button3_Click;
            // 
            // FormularioClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 460);
            Controls.Add(btnLimpiar);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormularioClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioClientes";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        protected Label label1;
        protected Label label2;
        protected Label label10;
        protected Label label6;
        private TextBox textBox3;
        protected Label label5;
        protected Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private BindingSource bindingSource1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Button btnLimpiar;
    }
}