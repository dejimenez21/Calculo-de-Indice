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
    public partial class FormProfesor : Form
    {
        DataManager datamanager = new DataManager();
        Profesor profesor = new Profesor();
        List<Asignatura> asignaturas = new List<Asignatura>();

        public FormProfesor(Profesor profesor)
        {
            InitializeComponent();
            this.profesor = profesor;
            InformacionGeneral();
            AsignaturasImpartidas();
            CompletarDtgv();
        }

        void InformacionGeneral()
        {
            tbId.Text = profesor.Id.ToString();
            tbNombre.Text = profesor.Nombre + " " + profesor.Apellido;
        }

        void AsignaturasImpartidas()
        {
            datamanager.RecuperarAsignaturas();
            foreach (var asig in datamanager.Asignaturas.Where(x=>x.Profesor.Id==profesor.Id))
            {
                asignaturas.Add(asig);
            }
        }

        DataTable IniciarDataTable()
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

            return Data;
        }

        void CompletarDtgv()
        {
            DataTable Data = IniciarDataTable();
            foreach (var asig in asignaturas)
            {
                DataRow row;
                row = Data.NewRow();
                row["Clave"] = asig.Clave;
                row["Descripcion"] = asig.Descripcion;
                row["Creditos"] = asig.Creditos;
                Data.Rows.Add(row);
            }

            dtgvAsignaturas.DataSource = Data;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir? Su sesion sera cerrada", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            string clave = tbClave.Text;
            CalificarEstudiantes calificarEstudiantes = new CalificarEstudiantes();

            if (clave == "")
            {
                MessageBox.Show("Por favor ingrese la clave de la asignatura a calificar");
                return;
            }

            if (!asignaturas.Any(x=>x.Clave==clave))
            {
                MessageBox.Show("Usted no imparte ninguna asignatura con esta clave");
                return;
            }

            foreach (var asig in asignaturas.Where(x=>x.Clave==clave))
            {
                calificarEstudiantes.asignatura=asig;
                calificarEstudiantes.Show();
                this.Hide();
            }

            
        }
    }
}
