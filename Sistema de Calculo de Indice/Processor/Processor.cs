using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Control
{
    public class Processor
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Profesor> Profesores = new List<Profesor>();
        List<Carrera> Carreras = new List<Carrera>();

        public Estudiante ValidarEstudiante(int user, string password, out bool login)
        {
            Estudiante estudiante = new Estudiante(user, password);
            DataManager datamanager = new DataManager();
            estudiantes = datamanager.RecuperarEstudiantes();

            foreach (var est in estudiantes.Where(x=>x.Id==user&&x.Constraseña==password))
            {
                login = true;
                return est;
            }
            
            login = false;
            return estudiante;
        }
    }
}
