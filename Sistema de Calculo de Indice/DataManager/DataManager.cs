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
    public class DataManager
    {
        string pathEstudiantes = ConfigurationManager.AppSettings["pathEstudiantes"];
        string pathProfesores = ConfigurationManager.AppSettings["pathProfesores"];
        string pathCarreras = ConfigurationManager.AppSettings["pathCarreras"];

        public List<Estudiante> Estudiantes = new List<Estudiante>();
        public List<Profesor> Profesores = new List<Profesor>();
        public List<Carrera> Carreras = new List<Carrera>();

        #region Recuperar
        public List<Estudiante> RecuperarEstudiantes()
        {
            string archivoEstudiantes = File.ReadAllText(pathEstudiantes);

            if (archivoEstudiantes.Length != 0)
                Estudiantes = JsonConvert.DeserializeObject<List<Estudiante>>(archivoEstudiantes);
            return Estudiantes;
        }

        void RecuperarProfesores()
        {
            string archivoProfesores = File.ReadAllText(pathProfesores);

            if (archivoProfesores.Length != 0)
                Profesores = JsonConvert.DeserializeObject<List<Profesor>>(archivoProfesores);
        }

        void RecuperarCarreras()
        {
            string archivoCarreras = File.ReadAllText(pathCarreras);

            if (archivoCarreras.Length != 0)
                Carreras = JsonConvert.DeserializeObject<List<Carrera>>(archivoCarreras);
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
        #endregion
        #region Agregar
        public void AgregarEstudiante(Estudiante estudiante)
        {
            if (!Estudiantes.Any())
            {
                RecuperarEstudiantes();
            }

            Estudiantes.Add(estudiante);
            GuardarEstudiantes();
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


    }
}
