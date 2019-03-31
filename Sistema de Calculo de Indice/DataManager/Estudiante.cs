using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class Estudiante : Usuarios
    {
        Carrera Carrera;
        List<Asignatura> asignaturas = new List<Asignatura>();

        public void AgregarAsignatura(Asignatura asignatura)
        {
            asignaturas.Add(asignatura);
        }
    }
}
