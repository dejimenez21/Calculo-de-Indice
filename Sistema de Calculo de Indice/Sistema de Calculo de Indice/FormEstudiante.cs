﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace Sistema_de_Calculo_de_Indice
{
    public partial class FormEstudiante : Form
    {
        Estudiante estudiante;

        public FormEstudiante(Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn Log = new LogIn();
            Log.Show();
            this.Hide();
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
