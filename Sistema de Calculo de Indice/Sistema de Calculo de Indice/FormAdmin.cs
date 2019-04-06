using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Calculo_de_Indice
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConfigUsuarios formEstudiante = new ConfigUsuarios();
            formEstudiante.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            LogIn Log = new LogIn();
            Log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GestCarreras gestCarreras = new GestCarreras();
            gestCarreras.Show();
            this.Hide();
        }
    }
}
