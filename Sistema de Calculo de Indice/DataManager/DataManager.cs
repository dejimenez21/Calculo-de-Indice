using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;

namespace DataModel
{
    static class ID
    {
        internal static long Estudiantes;
        internal static long Profesores;
    }
    
    public class DataManager
    {
        string pathEstudiantes = ConfigurationManager.AppSettings["pathEstudiantes"];
        string pathProfesores = ConfigurationManager.AppSettings["pathProfesores"];
        string pathCarreras = ConfigurationManager.AppSettings["pathCarreras"];
        string pathIdEst = ConfigurationManager.AppSettings["pathIdEst"];
        string pathIdProf = ConfigurationManager.AppSettings["pathIdProf"];

        public List<Estudiante> Estudiantes = new List<Estudiante>();
        public List<Profesor> Profesores = new List<Profesor>();
        public List<Carrera> Carreras = new List<Carrera>();

        public DataManager()
        {
            RecuperarIds();
        }

        #region Recuperar
        public void RecuperarEstudiantes()
        {
            string archivoEstudiantes = File.ReadAllText(pathEstudiantes);

            if (archivoEstudiantes.Count() != 0)
                Estudiantes = JsonConvert.DeserializeObject<List<Estudiante>>(archivoEstudiantes);

        }

        public void RecuperarProfesores()
        {
            string archivoProfesores = File.ReadAllText(pathProfesores);

            if (archivoProfesores.Length != 0)
                Profesores = JsonConvert.DeserializeObject<List<Profesor>>(archivoProfesores);

        }

        public List<Carrera> RecuperarCarreras()
        {
            string archivoCarreras = File.ReadAllText(pathCarreras);

            if (archivoCarreras.Any())
                Carreras = JsonConvert.DeserializeObject<List<Carrera>>(archivoCarreras);
            return Carreras;
        }

        public void RecuperarIds()
        {
            ID.Estudiantes = long.Parse(File.ReadAllText(pathIdEst));
            ID.Profesores = long.Parse(File.ReadAllText(pathIdProf));
        }
        #endregion
        #region Guardar
        void GuardarEstudiantes()
        {
            string strEstudiantes = JsonConvert.SerializeObject(Estudiantes);
            File.WriteAllText(pathEstudiantes, strEstudiantes);
        }

        void GuardarProfesores()
        {
            string strProfesores = JsonConvert.SerializeObject(Profesores);
            File.WriteAllText(pathProfesores, strProfesores);
        }

        void GuardarCarreras()
        {
            string strCarreras = JsonConvert.SerializeObject(Carreras);
            File.WriteAllText(pathCarreras, strCarreras);
        }

        void GuardarIds()
        {
            File.WriteAllText(pathIdEst, ID.Estudiantes.ToString());
            File.WriteAllText(pathIdProf, ID.Profesores.ToString());
        }
        #endregion
        #region Agregar
        public long AgregarEstudiante(Estudiante estudiante)
        {
            if (!Estudiantes.Any())
            {
                RecuperarEstudiantes();
            }

            estudiante.Id = ID.Estudiantes;
            ID.Estudiantes++;

            Estudiantes.Add(estudiante);
            GuardarEstudiantes();
            GuardarIds();
            return estudiante.Id;
        }


        public void AgregarProfesor(Profesor profesor)
        {
            if (!Profesores.Any())
            {
                RecuperarProfesores();
            }

            Profesores.Add(profesor);
            GuardarProfesores();
        }

        public void AgregarCarreras(Carrera carrera)
        {
            if (!Carreras.Any())
            {
                RecuperarCarreras();
            }

            Carreras.Add(carrera);
            GuardarCarreras();
        }
        #endregion

        #region Eliminar
        public bool EliminarEstudiante(long id)
        {
            if (!Estudiantes.Any())
            {
                RecuperarEstudiantes();
            }

            if(Estudiantes.RemoveAll(x => x.Id == id)==0)
                return false;
            GuardarEstudiantes();
            return true;
        }
        #endregion
    }
}
