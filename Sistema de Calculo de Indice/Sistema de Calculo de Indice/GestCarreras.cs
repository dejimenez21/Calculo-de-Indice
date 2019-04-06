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
    public partial class GestCarreras : Form
    {
        DataManager dataManager = new DataManager();

        public GestCarreras()
        {
            InitializeComponent();
            IniciarDGView();
        }

        public void IniciarDGView()
        {
            dataManager.RecuperarCarreras();
            dtgvCarreras.DataSource = dataManager.Carreras;
            dtgvCarreras.Columns["Codigo"].Width = 60;
            dtgvCarreras.Columns["Descripcion"].Width = 156;
        }

        public void FormRefresh()
        {
            IniciarDGView();
            tbCodigo.Clear();
            tbElimCodigo.Clear();
            tbDescripcion.Clear();
        }

        private void btnAgregCarrera_Click(object sender, EventArgs e)
        {
            string codigo = tbCodigo.Text;
            string descripcion = tbDescripcion.Text;
            Carrera carrera = new Carrera(codigo, descripcion);

            if (!dataManager.VerificarCarrera(codigo))
            {
                dataManager.AgregarCarreras(carrera);
                MessageBox.Show("Carrera agregada exitosamente");
            }
            else
            {
                MessageBox.Show("Este codigo de carrera ya esta en uso");
            }
            FormRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormAdmin Admin = new FormAdmin();
            Admin.Show();
            this.Hide();
        }

        private void btnElimCarrera_Click(object sender, EventArgs e)
        {
            string codigo = tbElimCodigo.Text;

            if (!dataManager.VerificarCarrera(codigo))
            {
                MessageBox.Show("La carrera ingresada no esta registrada");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea eliminar esta carrera?", "Eliminar carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataManager.EliminarCarrera(codigo);
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al eliminar la carrera");
                        FormRefresh();
                        return;
                    }

                    MessageBox.Show("Estudiante eliminado exitosamente");
                    
                    
                }
            }

            FormRefresh();
        }
    }
}
