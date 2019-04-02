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
        }

        private void btnAgregCarrera_Click(object sender, EventArgs e)
        {
            string codigo = tbCodigo.Text;
            string descripcion = tbDescripcion.Text;

            Carrera carrera = new Carrera(codigo, descripcion);

            dataManager.AgregarCarreras(carrera);
        }
    }
}
