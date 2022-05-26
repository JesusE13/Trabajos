namespace Cedula
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LugardeNacimiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EstadoCivil = new System.Windows.Forms.ComboBox();
            this.Sangre = new System.Windows.Forms.ComboBox();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.FechadeExpiracion = new System.Windows.Forms.DateTimePicker();
            this.FechadeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Nacionalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttinguardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1135, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 372);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LugardeNacimiento
            // 
            this.LugardeNacimiento.Location = new System.Drawing.Point(-1, 34);
            this.LugardeNacimiento.Name = "LugardeNacimiento";
            this.LugardeNacimiento.Size = new System.Drawing.Size(125, 27);
            this.LugardeNacimiento.TabIndex = 2;
            this.LugardeNacimiento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "LUGAR DE NACIMIENTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "FECHA DE NACIMIENTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "NACIONALIDAD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(0, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "SEXO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(137, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "SANGRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "ESTADO CIVIL:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EstadoCivil);
            this.panel1.Controls.Add(this.Sangre);
            this.panel1.Controls.Add(this.Sexo);
            this.panel1.Controls.Add(this.FechadeExpiracion);
            this.panel1.Controls.Add(this.FechadeNacimiento);
            this.panel1.Controls.Add(this.Nacionalidad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LugardeNacimiento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(297, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 372);
            this.panel1.TabIndex = 9;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.FormattingEnabled = true;
            this.EstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.EstadoCivil.Location = new System.Drawing.Point(416, 240);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(84, 28);
            this.EstadoCivil.TabIndex = 24;
            // 
            // Sangre
            // 
            this.Sangre.FormattingEnabled = true;
            this.Sangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.Sangre.Location = new System.Drawing.Point(211, 240);
            this.Sangre.Name = "Sangre";
            this.Sangre.Size = new System.Drawing.Size(84, 28);
            this.Sangre.TabIndex = 23;
            // 
            // Sexo
            // 
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Sexo.Location = new System.Drawing.Point(47, 240);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(84, 28);
            this.Sexo.TabIndex = 22;
            this.Sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FechadeExpiracion
            // 
            this.FechadeExpiracion.Location = new System.Drawing.Point(3, 310);
            this.FechadeExpiracion.Name = "FechadeExpiracion";
            this.FechadeExpiracion.Size = new System.Drawing.Size(145, 27);
            this.FechadeExpiracion.TabIndex = 18;
            // 
            // FechadeNacimiento
            // 
            this.FechadeNacimiento.Location = new System.Drawing.Point(0, 104);
            this.FechadeNacimiento.Name = "FechadeNacimiento";
            this.FechadeNacimiento.Size = new System.Drawing.Size(145, 27);
            this.FechadeNacimiento.TabIndex = 17;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(-1, 186);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(125, 27);
            this.Nacionalidad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "FECHA DE EXPIRACION:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(840, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(965, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 13;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttinguardar
            // 
            this.buttinguardar.Location = new System.Drawing.Point(965, 477);
            this.buttinguardar.Name = "buttinguardar";
            this.buttinguardar.Size = new System.Drawing.Size(94, 29);
            this.buttinguardar.TabIndex = 15;
            this.buttinguardar.Text = "Guardar";
            this.buttinguardar.UseVisualStyleBackColor = true;
            this.buttinguardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nombres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Apellidos";
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(532, 76);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(196, 27);
            this.Apellidos.TabIndex = 18;
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(296, 76);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(187, 27);
            this.Nombres.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(846, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(388, 337);
            this.dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1258, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttinguardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox LugardeNacimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private TextBox Nacionalidad;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button buttinguardar;
        private Label label10;
        private Label label11;
        private TextBox Apellidos;
        private TextBox Nombres;
        private DataGridView dataGridView1;
        private DateTimePicker FechadeNacimiento;
        private ComboBox Sexo;
        private DateTimePicker FechadeExpiracion;
        private ComboBox EstadoCivil;
        private ComboBox Sangre;
    }
}