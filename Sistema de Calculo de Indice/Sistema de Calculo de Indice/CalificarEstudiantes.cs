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
    public partial class CalificarEstudiantes : Form
    {
        DataManager datamanager = new DataManager();
        List<Estudiante> estudiantes = new List<Estudiante>();
        public Asignatura asignatura;

        public CalificarEstudiantes()
        {
            InitializeComponent();       
        }

        void FormRefresh()
        {
            estudiantes = new List<Estudiante>();
            EstudiantesRegistrados();
            IniciarDataTable();

            tbID.Clear();
            tbCalif.Clear();
        }

        void EstudiantesRegistrados()
        {
            datamanager.RecuperarEstudiantes();
            foreach (var est in datamanager.Estudiantes.Where(x=>x.Asignaturas.Any(y=>y.Clave==asignatura.Clave)))
            {
                estudiantes.Add(est);
            }
        }

        void IniciarDataTable()
        {
            DataTable Data = new DataTable();
            DataColumn column;
            datamanager.RecuperarEstudiantes();

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

            column = new DataColumn();
            column.DataType = typeof(uint);
            column.ColumnName = "Calificacion";
            column.Caption = "Calificacion";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            foreach (var est in estudiantes)
            {
                DataRow row;
                row = Data.NewRow();
                row["ID"] = est.Id;
                row["Estudiante"] = est.Nombre + " " + est.Apellido;
                row["Carrera"] = est.carrera.Codigo + "-" + est.carrera.Descripcion;
                if(est.Asignaturas.Where(x => x.Clave == asignatura.Clave).ToList()[0].calificada)
                {
                    row["Calificacion"] = est.Asignaturas.Where(x => x.Clave == asignatura.Clave).ToList()[0].Calificacion;
                }
                
                Data.Rows.Add(row);
            }

            dtgvEstudiantes.DataSource = Data;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Su sesion sera cerrada", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormProfesor formProfesor= new FormProfesor(asignatura.Profesor);
            formProfesor.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Asignatura asig = asignatura;

            if (tbID.Text == "")
            {
                MessageBox.Show("Por favor ingrese el ID del estudiante a calificar");
                return;
            }

            if(!long.TryParse(tbID.Text, out long id))
            {
                MessageBox.Show("El ID de un estudiante solo contiene caracteres numericos");
                FormRefresh();
                return;
            }

            if (!estudiantes.Any(x => x.Id == id))
            {
                MessageBox.Show("No existe ningun estudiante con el ID ingresado en esta seccion");
                FormRefresh();
                return;
            }

            if (!uint.TryParse(tbCalif.Text, out uint calif))
            {
                MessageBox.Show("La calificacion ingresada no es valida");
                FormRefresh();
                return;
            }

            if (calif < 0 || calif > 100)
            {
                MessageBox.Show("Por favor ingrese una calificacion comprendida entre 0 - 100");
                FormRefresh();
                return;
            }

            asig.Calificacion = calif;

            datamanager.ActualizarCalificacion(asig, id);
            MessageBox.Show("Calificacion registrada exitosamente");
            FormRefresh();
        }

        private void CalificarEstudiantes_Load(object sender, EventArgs e)
        {
            EstudiantesRegistrados();
            IniciarDataTable();
        }
    }
}
