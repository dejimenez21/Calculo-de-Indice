using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DataModel;

namespace Sistema_de_Calculo_de_Indice
{
    public partial class ConfigUsuarios : Form
    {
        DataManager datamanager = new DataManager();
        public ConfigUsuarios()
        {
            InitializeComponent();

            LlenarComboBox();
            LlenarDataGridView();
            
        }

        void LlenarComboBox()
        {
            foreach (var item in datamanager.RecuperarCarreras())
            {
                string codigo = item.Codigo;
                string descripcion = item.Descripcion;
                cmbCarrera.Items.Add(codigo + "-" + descripcion);
            }
        }

        void LlenarDataGridView()
        {
            datamanager.RecuperarEstudiantes();
            dtgvEstudiantes.AutoGenerateColumns = true;
            dtgvEstudiantes.DataSource = datamanager.Estudiantes;
            dtgvEstudiantes.AutoGenerateColumns = false;
            dtgvEstudiantes.Columns.Remove("Contraseña");

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAdmin Admin = new FormAdmin();
            Admin.Show();
            this.Hide();
        }

        private void btnAgregEst_Click(object sender, EventArgs e)
        {
            string nombres = tbNombresEst.Text;
            string apellidos = tbApellidosEst.Text;
            long id;

            if (cmbCarrera.Text.Count() == 0)
            {
                MessageBox.Show("Debe seleccionar una carrera");
                return;
            }

            string[] splitted = cmbCarrera.Text.Split('-');
            Carrera carrera = new Carrera(splitted[0], splitted[1]);

            Estudiante estudiante = new Estudiante(nombres, apellidos, carrera);
            try
            {
                id = datamanager.AgregarEstudiante(estudiante);
            }
            catch
            {
                MessageBox.Show("Se produjo un error al agregar el estudiante");
                return;
            }
            MessageBox.Show($"Estudiante agregado exitosamente.\nID: {id}\nConstraseña(provisional): {id}");
            LlenarDataGridView();
            tbNombresEst.Clear();
            tbApellidosEst.Clear();
            cmbCarrera.Text = " ";

        }

        private void TipoDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Los tipos de usuario
        }

        private void btnElimEst_Click(object sender, EventArgs e)
        {
            bool ok;
            if (!long.TryParse(tbIdEst.Text, out long id))
            {
                MessageBox.Show("El id ingresado no es valido");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea eliminar estudiante?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        ok = datamanager.EliminarEstudiante(id);
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al eliminar el estudiante");
                        tbIdEst.Clear();
                        return;
                    }
                    if (ok)
                    {
                        MessageBox.Show("Estudiante eliminado exitosamente");
                        LlenarDataGridView();
                    }  
                    else
                    {
                        MessageBox.Show("El ID ingresado no esta registrado");
                    }

                }
            }
            tbIdEst.Clear();
        }
    }
}
