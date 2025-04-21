namespace SistemaDeImportadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            button11 = new Button();
            SidePanel = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button10 = new Button();
            button9 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            inicio1 = new Inicio();
            ventas1 = new Ventas();
            empleados1 = new Empleados();
            vehiculos1 = new Vehiculos();
            reportes1 = new Reportes();
            clientes1 = new Clientes();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 10);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(429, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 128);
            panel3.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 532);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Century Gothic", 11.25F);
            button11.ForeColor = Color.White;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.ImeMode = ImeMode.NoControl;
            button11.Location = new Point(12, 356);
            button11.Name = "button11";
            button11.Size = new Size(176, 52);
            button11.TabIndex = 8;
            button11.Text = "  Clientes";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(178, 8, 55);
            SidePanel.Location = new Point(0, 77);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 54);
            SidePanel.TabIndex = 3;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(12, 300);
            button5.Name = "button5";
            button5.Size = new Size(176, 52);
            button5.TabIndex = 7;
            button5.Text = "  Reportes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(12, 244);
            button4.Name = "button4";
            button4.Size = new Size(176, 52);
            button4.TabIndex = 6;
            button4.Text = "  Vehículos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(12, 188);
            button3.Name = "button3";
            button3.Size = new Size(176, 52);
            button3.TabIndex = 5;
            button3.Text = "   Empleados";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(12, 132);
            button2.Name = "button2";
            button2.Size = new Size(176, 52);
            button2.TabIndex = 4;
            button2.Text = "  Ventas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(176, 52);
            button1.TabIndex = 3;
            button1.Text = "  Inicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 11.25F);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImeMode = ImeMode.NoControl;
            button8.Location = new Point(285, 16);
            button8.Name = "button8";
            button8.Size = new Size(34, 47);
            button8.TabIndex = 14;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 11.25F);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.ImeMode = ImeMode.NoControl;
            button7.Location = new Point(245, 16);
            button7.Name = "button7";
            button7.Size = new Size(34, 47);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 11.25F);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImeMode = ImeMode.NoControl;
            button6.Location = new Point(205, 16);
            button6.Name = "button6";
            button6.Size = new Size(34, 47);
            button6.TabIndex = 12;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Century Gothic", 11.25F);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.ImeMode = ImeMode.NoControl;
            button10.Location = new Point(940, 16);
            button10.Name = "button10";
            button10.Size = new Size(34, 47);
            button10.TabIndex = 16;
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 11.25F);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.ImeMode = ImeMode.NoControl;
            button9.Location = new Point(980, 16);
            button9.Name = "button9";
            button9.Size = new Size(34, 47);
            button9.TabIndex = 15;
            button9.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox1);
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(426, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(326, 128);
            panel4.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 18F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(95, 86);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 13;
            label1.Text = "AutoVentas";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(-42, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // inicio1
            // 
            inicio1.BackgroundImage = (Image)resources.GetObject("inicio1.BackgroundImage");
            inicio1.Location = new Point(190, 154);
            inicio1.Name = "inicio1";
            inicio1.Size = new Size(853, 389);
            inicio1.TabIndex = 18;
            // 
            // ventas1
            // 
            ventas1.BackColor = SystemColors.Control;
            ventas1.Location = new Point(191, 154);
            ventas1.Name = "ventas1";
            ventas1.Size = new Size(853, 389);
            ventas1.TabIndex = 19;
            // 
            // empleados1
            // 
            empleados1.Location = new Point(191, 154);
            empleados1.Name = "empleados1";
            empleados1.Size = new Size(853, 389);
            empleados1.TabIndex = 20;
            // 
            // vehiculos1
            // 
            vehiculos1.Location = new Point(191, 154);
            vehiculos1.Name = "vehiculos1";
            vehiculos1.Size = new Size(853, 389);
            vehiculos1.TabIndex = 21;
            // 
            // reportes1
            // 
            reportes1.Location = new Point(191, 154);
            reportes1.Name = "reportes1";
            reportes1.Size = new Size(853, 389);
            reportes1.TabIndex = 22;
            // 
            // clientes1
            // 
            clientes1.Location = new Point(191, 154);
            clientes1.Name = "clientes1";
            clientes1.Size = new Size(853, 389);
            clientes1.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 542);
            Controls.Add(clientes1);
            Controls.Add(reportes1);
            Controls.Add(vehiculos1);
            Controls.Add(empleados1);
            Controls.Add(ventas1);
            Controls.Add(inicio1);
            Controls.Add(panel4);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Importadora";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel SidePanel;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button10;
        private Button button9;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
        private Inicio inicio1;
        private Ventas ventas1;
        private Empleados empleados1;
        private Vehiculos vehiculos1;
        private Reportes reportes1;
        private Button button11;
        private Clientes clientes1;
    }
}
