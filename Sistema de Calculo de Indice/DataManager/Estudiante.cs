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

        public Estudiante(int user, string password)
        {
            this.Id = user;
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            asignaturas.Add(asignatura);
        }
    }
}
