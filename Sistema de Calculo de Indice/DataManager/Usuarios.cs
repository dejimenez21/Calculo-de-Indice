using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Usuario
    {
        long id;
        string nombre;
        string apellido;
        string contraseña;
        protected bool Activo;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
