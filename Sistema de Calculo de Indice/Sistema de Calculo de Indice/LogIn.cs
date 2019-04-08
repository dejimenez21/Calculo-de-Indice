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
using Control;

namespace Sistema_de_Calculo_de_Indice
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbMostrar.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool login;
            Processor processor = new Processor();
            string password = tbPassword.Text;
            string tipo = cmbTipo.Text;

            if (tipo == "")
            {
                MessageBox.Show("Por favor seleccione un tipo de usuario");
                return;
            }

            if (tipo == "Administrador")
            {
                if (tbUser.Text == "dejimenez21" || password == "1234")
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return;
                }
            }

            if (!int.TryParse(tbUser.Text, out int user))
            {
                MessageBox.Show("Usuario no valido");
                return;
            }
            
            if (tipo == "Estudiante")
            {
                Estudiante estudiante = processor.ValidarEstudiante(user, password, out login);
                if (login == true)
                {
                    MessageBox.Show("Inicio de sesion exitoso");
                    FormEstudiante formEstudiante = new FormEstudiante(estudiante);
                    formEstudiante.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return;
                }
            }
            else
            {
                Profesor profesor = processor.ValidarProfesor(user, password, out login);
                if (login == true)
                {
                    MessageBox.Show("Inicio de sesion exitoso");
                    FormProfesor form = new FormProfesor(profesor);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    return;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
