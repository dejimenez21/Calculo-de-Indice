using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class Usuarios
    {
        int id;
        string nombre;
        string apellido;
        string constraseña;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Constraseña { get => constraseña; set => constraseña = value; }
    }
}
