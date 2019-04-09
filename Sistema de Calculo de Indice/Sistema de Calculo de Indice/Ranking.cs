using System;
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
    public partial class Ranking : Form
    {
        DataManager datamanager = new DataManager();

        public Ranking()
        {
            InitializeComponent();
            CompletarRanking();
        }

        void CompletarRanking()
        {

            dtgvRanking.DataSource = datamanager.Ranking();
            dtgvRanking.Columns["Posicion"].Width = 70;
            dtgvRanking.Columns["ID"].Width = 70;
            dtgvRanking.Columns["Estudiante"].Width = 190;
            dtgvRanking.Columns["Carrera"].Width = 235;
            dtgvRanking.Columns["Indice"].Width = 60;
            dtgvRanking.Columns["Honor"].Width = 130;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Su sesion sera cerrada", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }
    }
}
