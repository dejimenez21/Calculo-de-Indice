using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Estudiante : Usuario
    {
        Carrera Carrera;
        List<Asignatura> asignaturas = new List<Asignatura>();

        public Estudiante() { }
        public Estudiante(int user, string password)
        {
            this.Id = user;
        }
        public Estudiante(string nombres, string apellidos, Carrera carrera)
        {
            this.Nombre = nombres;
            this.Apellido = apellidos;
            this.Carrera = carrera;
            this.Contraseña = Id.ToString();
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            asignaturas.Add(asignatura);
        }
    }
}
