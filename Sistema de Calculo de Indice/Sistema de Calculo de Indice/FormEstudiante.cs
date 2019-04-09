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
    public partial class FormEstudiante : Form
    {
        DataManager datamanager = new DataManager();
        Estudiante estudiante;
        

        public FormEstudiante(Estudiante estudiante)
        {
            InitializeComponent();
            this.estudiante = estudiante;
            InformacionGeneral();
            FormRefresh();
        }

        void InformacionGeneral()
        {
            tbId.Text = estudiante.Id.ToString();
            tbNombre.Text = estudiante.Nombre + " " + estudiante.Apellido;
            tbCarrera.Text = estudiante.carrera.Codigo + "-" + estudiante.carrera.Descripcion;
        }

        void FormRefresh()
        {
            datamanager.RecuperarEstudiantes();
            CompletarDisponibles();
            CompletarSeleccionadas();
            tbClave.Clear();
        }

        List<Asignatura> AsignaturasDisponibles()
        {
            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas = datamanager.Asignaturas;
            foreach (var asig in estudiante.Asignaturas)
            {
                asignaturas.RemoveAll(x => x.Clave == asig.Clave);
            }
            return asignaturas;
        }

        DataTable IniciarDataTable()
        {
            DataTable Data = new DataTable();
            DataTable Selec = new DataTable();
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

            return Data;
        }

        void CompletarDisponibles()
        {
            DataTable Data = IniciarDataTable();
            foreach (var asig in AsignaturasDisponibles())
            {
                DataRow row;
                row = Data.NewRow();
                row["Clave"] = asig.Clave;
                row["Descripcion"] = asig.Descripcion;
                row["Creditos"] = asig.Creditos;
                row["Profesor"] = asig.Profesor.Nombre + " " + asig.Profesor.Apellido;
                Data.Rows.Add(row);
            }

            dtgvAsignaturas.DataSource = Data;

        }

        void CompletarSeleccionadas()
        {
            DataTable Data = IniciarDataTable();
            foreach (var asig in estudiante.Asignaturas)
            {
                DataRow row;
                row = Data.NewRow();
                row["Clave"] = asig.Clave;
                row["Descripcion"] = asig.Descripcion;
                row["Creditos"] = asig.Creditos;
                row["Profesor"] = asig.Profesor.Nombre + " " + asig.Profesor.Apellido;
                Data.Rows.Add(row);
            }

            dtgvSeleccionadas.DataSource = Data;
        }

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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string clave=tbClave.Text;

            if (clave == "")
            {
                MessageBox.Show("Por favor ingrese la clave de la asignatura a seleccionar");
                return;
            }

            if (estudiante.IsSeleccionada(clave))
            {
                MessageBox.Show("Esta asignatura ya fue seleccionada");
                return;
            }

            if (!datamanager.VerificarAsignatura(clave))
            {
                MessageBox.Show("No existe ninunga asignatura con esta clave");
                return;
            }

            Asignatura asignatura = datamanager.Asignaturas.Where(x => x.Clave == clave).ToList()[0];
            if (MessageBox.Show($"¿Seguro que desea seleccionar {asignatura.Descripcion}?", "Seleccionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                estudiante.AgregarAsignatura(asignatura);
                MessageBox.Show("Asignatura seleccionada exitosamente");
            }
            else
                return;

            datamanager.ActualizarEstudiante(estudiante);
            FormRefresh();
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {
            lbIndice.Text = estudiante.GetIndice().ToString();
            lbHonor.Text = estudiante.Honor;
            lbPuntos.Text = estudiante.TotalPuntosHonor.ToString();
            lbCreditos.Text = estudiante.TotalCreditos.ToString();
            DataTableCalificaciones();
        }

        void DataTableCalificaciones()
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

            column = new DataColumn();
            column.DataType = typeof(AlfaCalificacion);
            column.ColumnName = "Calificacion";
            column.Caption = "Calificacion";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(uint);
            column.ColumnName = "Valor";
            column.Caption = "Valor";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(uint);
            column.ColumnName = "Puntos de Honor";
            column.Caption = "Puntos de Honor";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            Data.Columns.Add(column);

            foreach (var asig in estudiante.Asignaturas.Where(x=>x.calificada))
            {
                DataRow row;
                row = Data.NewRow();
                row["Clave"] = asig.Clave;
                row["Descripcion"] = asig.Descripcion;
                row["Creditos"] = asig.Creditos;
                row["Profesor"] = asig.Profesor.Nombre + " " + asig.Profesor.Apellido;
                row["Calificacion"] = asig.Alfacalificacion;
                row["Valor"] = asig.ValorNota;
                row["Puntos de Honor"] = asig.PuntosHonor;
                Data.Rows.Add(row);
            }

            dtgvCalificaciones.DataSource = Data;
        }
    }
}
