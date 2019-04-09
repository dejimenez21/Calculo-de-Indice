namespace Sistema_de_Calculo_de_Indice
{
    partial class FormAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGestCarreras = new System.Windows.Forms.Button();
            this.btnGestAsignaturas = new System.Windows.Forms.Button();
            this.btnGestUsuarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRanking = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRanking);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGestCarreras);
            this.groupBox1.Controls.Add(this.btnGestAsignaturas);
            this.groupBox1.Controls.Add(this.btnGestUsuarios);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 318);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Administrador";
            // 
            // btnGestCarreras
            // 
            this.btnGestCarreras.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCarreras.Location = new System.Drawing.Point(71, 188);
            this.btnGestCarreras.Name = "btnGestCarreras";
            this.btnGestCarreras.Size = new System.Drawing.Size(177, 31);
            this.btnGestCarreras.TabIndex = 17;
            this.btnGestCarreras.Text = "Gestión de Carreras";
            this.btnGestCarreras.UseVisualStyleBackColor = true;
            this.btnGestCarreras.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnGestAsignaturas
            // 
            this.btnGestAsignaturas.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestAsignaturas.Location = new System.Drawing.Point(71, 113);
            this.btnGestAsignaturas.Name = "btnGestAsignaturas";
            this.btnGestAsignaturas.Size = new System.Drawing.Size(177, 31);
            this.btnGestAsignaturas.TabIndex = 17;
            this.btnGestAsignaturas.Text = "Gestión de Asignaturas";
            this.btnGestAsignaturas.UseVisualStyleBackColor = true;
            this.btnGestAsignaturas.Click += new System.EventHandler(this.btnGestAsignaturas_Click);
            // 
            // btnGestUsuarios
            // 
            this.btnGestUsuarios.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestUsuarios.Location = new System.Drawing.Point(71, 45);
            this.btnGestUsuarios.Name = "btnGestUsuarios";
            this.btnGestUsuarios.Size = new System.Drawing.Size(177, 31);
            this.btnGestUsuarios.TabIndex = 17;
            this.btnGestUsuarios.Text = "Gestión de Usuarios";
            this.btnGestUsuarios.UseVisualStyleBackColor = true;
            this.btnGestUsuarios.Click += new System.EventHandler(this.btnGestUsuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "--- Gestiona la organización y disponibilidad\r\n    de las carreras del sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "--- Organiza las asignaturas del sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "--- Agrega o elimina usuarios del sistema ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 16F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(285, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "Sistema Académico";
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.Location = new System.Drawing.Point(71, 259);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(177, 31);
            this.btnRanking.TabIndex = 19;
            this.btnRanking.Text = "Ranking de Estudiantes";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "--- Muestra el ranking organizado de estudiantes \r\n    segun su indice academico";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.mimizar;
            this.btnMinimize.Location = new System.Drawing.Point(696, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestCarreras;
        private System.Windows.Forms.Button btnGestAsignaturas;
        private System.Windows.Forms.Button btnGestUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Label label4;
    }
}