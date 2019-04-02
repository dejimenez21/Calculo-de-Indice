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
       
        public Estudiante ValidarEstudiante(int user, string password, out bool login)
        {
            Estudiante estudiante = new Estudiante(user, password);
            DataManager datamanager = new DataManager();
            datamanager.RecuperarEstudiantes();

            foreach (var est in datamanager.Estudiantes.Where(x=>x.Id==user&&x.Contraseña==password))
            {
                login = true;
                return est;
            }
            
            login = false;
            return estudiante;
        }

    }
}
