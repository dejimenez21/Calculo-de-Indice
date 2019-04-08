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

            IniciarDataTable();
            LlenarComboBox();
            

        }

        //Actualiza el form
        void FormRefresh()
        {
            IniciarDataTable();
            tbNombresEst.Clear();
            tbApellidosEst.Clear();
            tbIdEst.Clear();
            cmbCarrera.Text = " ";

            tbProfApellidos.Clear();
            tbProfNombres.Clear();
            tbElimProf.Clear();
        }

        //Carga los datos en el GridView
        void IniciarDataTable()
        {
            DataTable Data = new DataTable();
            DataColumn column;
            datamanager.RecuperarEstudiantes();
            datamanager.RecuperarProfesores();

            column = new DataColumn();
            column.DataType = typeof(long);
            column.ColumnName = "ID";
            column.Caption = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Estudiante";
            column.Caption = "Estudiante";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Carrera";
            column.Caption = "Carrera";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            
            Data.Columns.Add(column);

            foreach (var est in datamanager.Estudiantes)
            {
                DataRow row;
                row = Data.NewRow();
                row["ID"] = est.Id;
                row["Estudiante"] = est.Nombre + " " + est.Apellido;
                row["Carrera"] = est.carrera.Codigo + "-" + est.carrera.Descripcion;
                Data.Rows.Add(row);
            }

            dtgvEstudiantes.DataSource = Data;
            dtgvEstudiantes.Columns["Carrera"].Width = 200;

            //DataGridView de profesores
            dtgvProfesores.AutoGenerateColumns = true;
            dtgvProfesores.DataSource = datamanager.Profesores;
            dtgvProfesores.AutoGenerateColumns = false;
            dtgvProfesores.Columns.Remove("Contraseña");
        }

        
        //Carga las carreras disponibles en el ComboBox
        void LlenarComboBox()
        {
            foreach (var item in datamanager.RecuperarCarreras())
            {
                string codigo = item.Codigo;
                string descripcion = item.Descripcion;
                cmbCarrera.Items.Add(codigo + "-" + descripcion);
            }
        }

       
        //Atras
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FormAdmin Admin = new FormAdmin();
            Admin.Show();
            this.Hide();
        }

        //Agrega un estudiante
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
            FormRefresh();
            

        }

        //Elimina un estudiante
        private void btnElimEst_Click(object sender, EventArgs e)
        {
            bool ok;
            if (!long.TryParse(tbIdEst.Text, out long id))
            {
                MessageBox.Show("El id ingresado no es valido");
                FormRefresh();
                return;
            }

            if (!datamanager.VerificarEstudiante(id))
            {
                MessageBox.Show("El ID ingresado no esta registrado");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea eliminar estudiante?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        datamanager.EliminarEstudiante(id);
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al eliminar el estudiante");
                        FormRefresh();
                        return;
                    }
                    MessageBox.Show("Estudiante eliminado exitosamente");
                }
            }
            FormRefresh();
        }

        //Cierra la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Su sesion sera cerrada", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                return;

        }

        //Minimiza la aplicacion
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        //Agrega un profesor
        private void btnAgregProf_Click(object sender, EventArgs e)
        {
            long id;
            string nombres = tbProfNombres.Text;
            string apellidos = tbProfApellidos.Text;

            Profesor profesor = new Profesor(nombres, apellidos);
            id = datamanager.AgregarProfesor(profesor);
            //try
            //{
            //    id = datamanager.AgregarProfesor(profesor);
            //}
            //catch
            //{
            //    MessageBox.Show("Se produjo un error al agregar el profesor");
            //    return;
            //}
            MessageBox.Show($"Profesor agregado exitosamente.\nID: {id}\nConstraseña(provisional): {id}");
            FormRefresh();
        }

        //Elimina un profesor
        private void btnElimProf_Click(object sender, EventArgs e)
        {
            long id;
            if(!long.TryParse(tbElimProf.Text, out id))
            {
                MessageBox.Show("El id ingresado no es valido");
                FormRefresh();
                return;
            }

            if (!datamanager.VerificarProfesor(id))
            {
                MessageBox.Show("La carrera ingresada no esta registrada");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea eliminar este Profesor?", "Eliminar Profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        datamanager.EliminarProfesor(id);
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al eliminar el profesor");
                        FormRefresh();
                        return;
                    }

                    MessageBox.Show("Profesor eliminado exitosamente");


                }
            }

            FormRefresh();
        }
    }
}
