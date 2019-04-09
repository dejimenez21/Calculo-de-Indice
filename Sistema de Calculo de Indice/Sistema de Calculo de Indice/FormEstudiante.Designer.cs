namespace Sistema_de_Calculo_de_Indice
{
    partial class FormEstudiante
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvSeleccionadas = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCreditos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbHonor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbIndice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCarrera = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEstatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSeleccionadas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignaturas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalificaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.new_resize_close;
            this.btnSalir.Location = new System.Drawing.Point(734, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(43, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.mimizar;
            this.btnMinimize.Location = new System.Drawing.Point(696, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtras.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.Webp_net_resizeimage;
            this.btnAtras.Location = new System.Drawing.Point(24, 8);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(41, 29);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 338);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seleccionar Materias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvSeleccionadas);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(525, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(264, 306);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignaturas Seleccionadas";
            // 
            // dtgvSeleccionadas
            // 
            this.dtgvSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSeleccionadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSeleccionadas.Location = new System.Drawing.Point(3, 17);
            this.dtgvSeleccionadas.Name = "dtgvSeleccionadas";
            this.dtgvSeleccionadas.Size = new System.Drawing.Size(258, 285);
            this.dtgvSeleccionadas.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSeleccionar);
            this.groupBox4.Controls.Add(this.tbClave);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(290, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 160);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccionar Asignatura";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSeleccionar.Location = new System.Drawing.Point(45, 96);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(120, 32);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(27, 51);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(164, 23);
            this.tbClave.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "Clave de Asignatura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvAsignaturas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(264, 306);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas Disponibles";
            // 
            // dtgvAsignaturas
            // 
            this.dtgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAsignaturas.Location = new System.Drawing.Point(3, 17);
            this.dtgvAsignaturas.Name = "dtgvAsignaturas";
            this.dtgvAsignaturas.Size = new System.Drawing.Size(258, 285);
            this.dtgvAsignaturas.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbHonor);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbIndice);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte de Calificaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbPuntos.ForeColor = System.Drawing.Color.Black;
            this.lbPuntos.Location = new System.Drawing.Point(302, 524);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(24, 17);
            this.lbPuntos.TabIndex = 45;
            this.lbPuntos.Text = "45";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(124, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Total Puntos de Honor :";
            // 
            // lbCreditos
            // 
            this.lbCreditos.AutoSize = true;
            this.lbCreditos.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbCreditos.ForeColor = System.Drawing.Color.Black;
            this.lbCreditos.Location = new System.Drawing.Point(653, 523);
            this.lbCreditos.Name = "lbCreditos";
            this.lbCreditos.Size = new System.Drawing.Size(24, 17);
            this.lbCreditos.TabIndex = 43;
            this.lbCreditos.Text = "15";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(475, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 42;
            this.label11.Text = "Total Creditos :";
            // 
            // lbHonor
            // 
            this.lbHonor.AutoSize = true;
            this.lbHonor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbHonor.Font = new System.Drawing.Font("Roboto", 16F);
            this.lbHonor.ForeColor = System.Drawing.Color.Black;
            this.lbHonor.Location = new System.Drawing.Point(528, 31);
            this.lbHonor.Name = "lbHonor";
            this.lbHonor.Size = new System.Drawing.Size(227, 29);
            this.lbHonor.TabIndex = 34;
            this.lbHonor.Text = "Magna Cumme Laude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 16F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(414, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Honor:";
            // 
            // lbIndice
            // 
            this.lbIndice.AutoSize = true;
            this.lbIndice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIndice.Font = new System.Drawing.Font("Roboto", 16F);
            this.lbIndice.ForeColor = System.Drawing.Color.Black;
            this.lbIndice.Location = new System.Drawing.Point(239, 31);
            this.lbIndice.Name = "lbIndice";
            this.lbIndice.Size = new System.Drawing.Size(56, 29);
            this.lbIndice.TabIndex = 32;
            this.lbIndice.Text = "3.98";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "Indice Académico:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvCalificaciones);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(3, 79);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(789, 230);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calificaciones";
            // 
            // dtgvCalificaciones
            // 
            this.dtgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCalificaciones.Location = new System.Drawing.Point(3, 17);
            this.dtgvCalificaciones.Name = "dtgvCalificaciones";
            this.dtgvCalificaciones.Size = new System.Drawing.Size(783, 209);
            this.dtgvCalificaciones.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCarrera);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbEstatus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 92);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General";
            // 
            // tbCarrera
            // 
            this.tbCarrera.AutoSize = true;
            this.tbCarrera.Font = new System.Drawing.Font("Roboto", 10F);
            this.tbCarrera.ForeColor = System.Drawing.Color.Black;
            this.tbCarrera.Location = new System.Drawing.Point(534, 23);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(147, 17);
            this.tbCarrera.TabIndex = 41;
            this.tbCarrera.Text = "Ingenieria de Sistemas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(451, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Carrera:";
            // 
            // tbEstatus
            // 
            this.tbEstatus.AutoSize = true;
            this.tbEstatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.tbEstatus.ForeColor = System.Drawing.Color.Black;
            this.tbEstatus.Location = new System.Drawing.Point(534, 60);
            this.tbEstatus.Name = "tbEstatus";
            this.tbEstatus.Size = new System.Drawing.Size(47, 17);
            this.tbEstatus.TabIndex = 39;
            this.tbEstatus.Text = "Activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(451, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Estatus:";
            // 
            // tbId
            // 
            this.tbId.AutoSize = true;
            this.tbId.Font = new System.Drawing.Font("Roboto", 10F);
            this.tbId.ForeColor = System.Drawing.Color.Black;
            this.tbId.Location = new System.Drawing.Point(207, 23);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(64, 17);
            this.tbId.TabIndex = 37;
            this.tbId.Text = "1084357";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(124, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Id:";
            // 
            // tbNombre
            // 
            this.tbNombre.AutoSize = true;
            this.tbNombre.Font = new System.Drawing.Font("Roboto", 10F);
            this.tbNombre.ForeColor = System.Drawing.Color.Black;
            this.tbNombre.Location = new System.Drawing.Point(207, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(101, 17);
            this.tbNombre.TabIndex = 35;
            this.tbNombre.Text = "Daniel Jimenez";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(124, 59);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(63, 18);
            this.Nombre.TabIndex = 34;
            this.Nombre.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 16F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(302, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "Sistema Académico";
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCreditos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEstudiante";
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSeleccionadas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignaturas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCalificaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tbCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbEstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvAsignaturas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvSeleccionadas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbHonor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbIndice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvCalificaciones;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCreditos;
        private System.Windows.Forms.Label label11;
    }
}