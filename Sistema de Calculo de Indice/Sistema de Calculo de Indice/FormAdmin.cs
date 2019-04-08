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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Su sesion sera cerrada", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                return;

        }

        //Cierra sesion
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogIn Log = new LogIn();
                Log.Show();
                this.Hide();
            }
            else
                return;
        }

        //Minimiza la ventana
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Abre el form para gestionar los usuarios
        private void btnGestUsuarios_Click(object sender, EventArgs e)
        {
            ConfigUsuarios formEstudiante = new ConfigUsuarios();
            formEstudiante.Show();
            this.Hide();
        }

        //Abre el form para gestionar las asignaturas
        private void btnGestAsignaturas_Click(object sender, EventArgs e)
        {
            GestAsignaturas gest = new GestAsignaturas();
            gest.Show();
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
