using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Profesor : Usuario
    {
        public Profesor() { }

        public Profesor(string nombres, string apellidos)
        {
            this.Nombre = nombres;
            this.Apellido = apellidos;
        }

        public Profesor(long user, string password)
        {
            this.Id = user;
            this.Contraseña = password;
        }
    }
}
