namespace Sistema_de_Calculo_de_Indice
{
    partial class FormProfesor
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 16F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(257, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "Asignaccion de Calificaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 58);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General";
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
            this.tbNombre.Location = new System.Drawing.Point(534, 23);
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
            this.Nombre.Location = new System.Drawing.Point(451, 22);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(67, 18);
            this.Nombre.TabIndex = 34;
            this.Nombre.Text = "Profesor:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBox4);
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 126);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 270);
            this.panel.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalificar);
            this.groupBox4.Controls.Add(this.tbClave);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(563, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 160);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asignatura a Calificar";
            // 
            // btnCalificar
            // 
            this.btnCalificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCalificar.Location = new System.Drawing.Point(45, 96);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(120, 32);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(534, 270);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas Impartidas";
            // 
            // dtgvAsignaturas
            // 
            this.dtgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAsignaturas.Location = new System.Drawing.Point(3, 17);
            this.dtgvAsignaturas.Name = "dtgvAsignaturas";
            this.dtgvAsignaturas.Size = new System.Drawing.Size(528, 249);
            this.dtgvAsignaturas.TabIndex = 16;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.mimizar;
            this.btnMinimize.Location = new System.Drawing.Point(696, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.new_resize_close;
            this.btnSalir.Location = new System.Drawing.Point(743, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(43, 36);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnAtras.TabIndex = 8;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfesor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvAsignaturas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label10;
    }
}