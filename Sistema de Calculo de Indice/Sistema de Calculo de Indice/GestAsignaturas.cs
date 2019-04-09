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
    public partial class GestAsignaturas : Form
    {
        DataManager datamanager = new DataManager();

        public GestAsignaturas()
        {
            InitializeComponent();
            IniciarDataTable();
            
        }

        void FormRefresh()
        {
            IniciarDataTable();
            foreach(var group in Controls.OfType<GroupBox>())
            {
                foreach (var control in group.Controls.OfType<TextBox>())
                {
                    control.Clear();
                }
            }
            cmbProfesor.DataSource = new List<string>();
        }

        //Carga los datos en el GridView
        void IniciarDataTable()
        {
            DataTable Data = new DataTable();
            DataColumn column;
            datamanager.RecuperarAsignaturas();
            

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Clave";
            column.Caption = "Clave";
            column.ReadOnly = true;
            column.Unique = true;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Descripcion";
            column.Caption = "Descripcion";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(uint);
            column.ColumnName = "Creditos";
            column.Caption = "Creditos";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Profesor";
            column.Caption = "Profesor";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            foreach (var asig in datamanager.Asignaturas)
            {
                DataRow row;
                row = Data.NewRow();
                row["Clave"] = asig.Clave;
                row["Descripcion"] = asig.Descripcion;
                row["Creditos"] = asig.Creditos;
                row["Profesor"] = asig.Profesor.Nombre+" "+asig.Profesor.Apellido;
                Data.Rows.Add(row);
            }

            dtgvAsignaturas.DataSource = Data;

        }
        
        //Carga los profesores en el combo
        void LlenarComboBox()
        {
            Dictionary<string, long> pairs = new Dictionary<string, long>();
            datamanager.RecuperarProfesores();

            foreach (var item in datamanager.Profesores)
            {
                string nombre = item.Nombre;
                string apellido = item.Apellido;
                long id = item.Id;
                pairs.Add(nombre + " " + apellido, id);
            }

            cmbProfesor.DataSource = new BindingSource(pairs, null);
            cmbProfesor.DisplayMember = "Key";
            cmbProfesor.ValueMember = "Value";

            //foreach (var item in datamanager.Profesores)
            //{
            //    string nombre = item.Nombre;
            //    string apellido = item.Apellido;
            //    cmbProfesor.Items.Add(nombre + " " + apellido);
            //}
        }

        //Salir de la app
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Su sesion sera cerrada", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        //Minimizar app
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string clave = tbAgregClave.Text;
            string descripcion = tbDescripcion.Text;
            if(!uint.TryParse(tbCreditos.Text, out uint creditos))
            {
                MessageBox.Show("La cantidad de creditos ingresada no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Asignatura asignatura = new Asignatura(clave, descripcion, creditos);

            if (datamanager.VerificarAsignatura(clave))
            {
                MessageBox.Show("Esta clave de asignatura ya esta en uso");
                return;
            }
            else
            {
                datamanager.AgregarAsignaturas(asignatura);
                MessageBox.Show("Carrera agregada exitosamente");
            }
            FormRefresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string clave = tbElimClave.Text;
            if (!datamanager.VerificarAsignatura(clave))
            {
                MessageBox.Show("No existe ninunga asignatura con esta clave");
                FormRefresh();
                return;
            }

            if (!datamanager.ComprobarEliminarAsignatura(clave))
            {
                MessageBox.Show("Algunos estudiantes estan cursando esta asignatura. No es posible eliminarla");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que quiere eliminar esta asignatura?", "Eliminar asignatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    datamanager.EliminarAsignatura(clave);
                    MessageBox.Show("Asignatura eliminada exitosamente");
                }
            }
            
            FormRefresh();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string clave = tbAsigClave.Text;
            long prof=((KeyValuePair<string, long>)cmbProfesor.SelectedItem).Value;
            string nombre = ((KeyValuePair<string, long>)cmbProfesor.SelectedItem).Key;

            if (datamanager.VerificarAsignatura(clave))
            {
                if(MessageBox.Show($"¿Seguro que quiere asignar {clave} a {nombre}?", "Asignar asignatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    datamanager.AsignarProfesor(clave, prof);
                    MessageBox.Show("Asignatura asignada exitosamente");
                }
                
            }
            else
            {
                MessageBox.Show("No existe ninunga asignatura con esta clave");
            }
            FormRefresh();
        }

        private void cmbProfesor_Click(object sender, EventArgs e)
        {
            LlenarComboBox();
        }
    }
}
