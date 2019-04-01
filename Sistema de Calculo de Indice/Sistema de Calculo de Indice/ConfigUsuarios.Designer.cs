namespace Sistema_de_Calculo_de_Indice
{
    partial class ConfigUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.agrUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agrPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregUser = new System.Windows.Forms.Button();
            this.btnElimUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de usuario/ ID";
            // 
            // TipoDeUsuario
            // 
            this.TipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeUsuario.FormattingEnabled = true;
            this.TipoDeUsuario.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.TipoDeUsuario.Location = new System.Drawing.Point(78, 68);
            this.TipoDeUsuario.Name = "TipoDeUsuario";
            this.TipoDeUsuario.Size = new System.Drawing.Size(289, 25);
            this.TipoDeUsuario.TabIndex = 2;
            this.TipoDeUsuario.SelectedIndexChanged += new System.EventHandler(this.TipoDeUsuario_SelectedIndexChanged);
            // 
            // agrUsuario
            // 
            this.agrUsuario.Location = new System.Drawing.Point(78, 138);
            this.agrUsuario.Name = "agrUsuario";
            this.agrUsuario.Size = new System.Drawing.Size(199, 23);
            this.agrUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(75, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña";
            // 
            // agrPassword
            // 
            this.agrPassword.Location = new System.Drawing.Point(78, 210);
            this.agrPassword.Name = "agrPassword";
            this.agrPassword.PasswordChar = '*';
            this.agrPassword.Size = new System.Drawing.Size(199, 23);
            this.agrPassword.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregUser);
            this.groupBox1.Controls.Add(this.btnElimUsuario);
            this.groupBox1.Controls.Add(this.agrPassword);
            this.groupBox1.Controls.Add(this.agrUsuario);
            this.groupBox1.Controls.Add(this.TipoDeUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(36, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración de Usuarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAgregUser
            // 
            this.btnAgregUser.BackColor = System.Drawing.Color.White;
            this.btnAgregUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregUser.ForeColor = System.Drawing.Color.Green;
            this.btnAgregUser.Location = new System.Drawing.Point(78, 266);
            this.btnAgregUser.Name = "btnAgregUser";
            this.btnAgregUser.Size = new System.Drawing.Size(120, 32);
            this.btnAgregUser.TabIndex = 5;
            this.btnAgregUser.Text = "Agregar usuario";
            this.btnAgregUser.UseMnemonic = false;
            this.btnAgregUser.UseVisualStyleBackColor = false;
            this.btnAgregUser.Click += new System.EventHandler(this.btnAgregUser_Click);
            // 
            // btnElimUsuario
            // 
            this.btnElimUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimUsuario.ForeColor = System.Drawing.Color.Red;
            this.btnElimUsuario.Location = new System.Drawing.Point(538, 266);
            this.btnElimUsuario.Name = "btnElimUsuario";
            this.btnElimUsuario.Size = new System.Drawing.Size(120, 32);
            this.btnElimUsuario.TabIndex = 4;
            this.btnElimUsuario.Text = "Eliminar usuario";
            this.btnElimUsuario.UseVisualStyleBackColor = true;
            this.btnElimUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.Webp_net_resizeimage;
            this.button1.Location = new System.Drawing.Point(24, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 29);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.mimizar;
            this.button2.Location = new System.Drawing.Point(696, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 25);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Sistema_de_Calculo_de_Indice.Properties.Resources.new_resize_close;
            this.button3.Location = new System.Drawing.Point(743, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 36);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ConfigUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigUsuarios";
            this.Text = "MenuAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoDeUsuario;
        private System.Windows.Forms.TextBox agrUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox agrPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnElimUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}