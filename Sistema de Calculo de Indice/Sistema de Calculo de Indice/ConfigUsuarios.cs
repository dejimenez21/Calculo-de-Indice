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

namespace Sistema_de_Calculo_de_Indice
{
    public partial class ConfigUsuarios : Form
    {
        public ConfigUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*aqui va el codigo de borrar al usuario 
                OJO: si ha sido agregado, o si se escribio el nombre de usuario o ID correctamente, sino que salga un mensaje que diga 
                lo siguiente: "Usuario no registrado"*/
                MessageBox.Show("Usuario eliminado");               

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAdmin Admin = new FormAdmin();
            Admin.Show();
            this.Hide();
        }

        private void btnAgregUser_Click(object sender, EventArgs e)
        {
            //poner que si usuario que se agrega es nuevo salga la siguiente sentencia
            MessageBox.Show("Usuario agregado exitosamente");
            //y que sino salga esta *MessageBox.Show("El Usuario ya ha sido agregado");

        }

        private void TipoDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Los tipos de usuario
        }
    }
}
