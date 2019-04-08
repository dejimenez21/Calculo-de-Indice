﻿using System;
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
        string pathAsignaturas = ConfigurationManager.AppSettings["pathAsignaturas"];
        string pathIdEst = ConfigurationManager.AppSettings["pathIdEst"];
        string pathIdProf = ConfigurationManager.AppSettings["pathIdProf"];

        public List<Estudiante> Estudiantes = new List<Estudiante>();
        public List<Profesor> Profesores = new List<Profesor>();
        public List<Carrera> Carreras = new List<Carrera>();
        public List<Asignatura> Asignaturas = new List<Asignatura>();

        public DataManager()
        {
            Profesores = new List<Profesor>();
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

            if (archivoProfesores.Count() != 0)
                Profesores = JsonConvert.DeserializeObject<List<Profesor>>(archivoProfesores);

        }

        public List<Carrera> RecuperarCarreras()
        {
            string archivoCarreras = File.ReadAllText(pathCarreras);

            if (archivoCarreras.Any())
                Carreras = JsonConvert.DeserializeObject<List<Carrera>>(archivoCarreras);
            return Carreras;
        }

        public List<Asignatura> RecuperarAsignaturas()
        {
            string archivoAsignaturas = File.ReadAllText(pathAsignaturas);

            if (archivoAsignaturas.Any())
                Asignaturas = JsonConvert.DeserializeObject<List<Asignatura>>(archivoAsignaturas);
            return Asignaturas;
        }

        public void RecuperarIds()
        {
            ID.Estudiantes = long.Parse(File.ReadAllText(pathIdEst));
            ID.Profesores = long.Parse(File.ReadAllText(pathIdProf));
        }
        #endregion
        #region Guardar
        public void GuardarEstudiantes()
        {
            string strEstudiantes = JsonConvert.SerializeObject(Estudiantes);
            File.WriteAllText(pathEstudiantes, strEstudiantes);
        }

        public void GuardarProfesores()
        {
            string strProfesores = JsonConvert.SerializeObject(Profesores);
            File.WriteAllText(pathProfesores, strProfesores);
        }

        public void GuardarCarreras()
        {
            string strCarreras = JsonConvert.SerializeObject(Carreras);
            File.WriteAllText(pathCarreras, strCarreras);
        }

        public void GuardarAsignaturas()
        {
            string strAsignaturas = JsonConvert.SerializeObject(Asignaturas);
            File.WriteAllText(pathAsignaturas, strAsignaturas);
        }

        public void GuardarIds()
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


        public long AgregarProfesor(Profesor profesor)
        {
            if (!Profesores.Any())
            {
                RecuperarProfesores();
            }

            profesor.Id = ID.Profesores;
            ID.Profesores--;

            Profesores.Add(profesor);
            GuardarProfesores();
            GuardarIds();
            return profesor.Id;
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

        public void AgregarAsignaturas(Asignatura asignatura)
        {
            if (!Asignaturas.Any())
            {
                RecuperarAsignaturas();
            }

            Asignaturas.Add(asignatura);
            GuardarAsignaturas();
        }
        #endregion
        #region Eliminar
        public void EliminarEstudiante(long id)
        {
            if (!Estudiantes.Any())
            {
                RecuperarEstudiantes();
            }

            Estudiantes.RemoveAll(x => x.Id == id);
            GuardarEstudiantes();
        }

        public void EliminarProfesor(long id)
        {
            if (!Profesores.Any())
            {
                RecuperarProfesores();
            }

            Profesores.RemoveAll(x => x.Id == id);
            GuardarProfesores();
        }

        public void EliminarCarrera(string codigo)
        {
            if (!Carreras.Any())
            {
                RecuperarCarreras();
            }

            Carreras.RemoveAll(x => x.Codigo == codigo);
            GuardarCarreras();
        }

        public void EliminarAsignatura(string clave)
        {
            if (!Asignaturas.Any())
            {
                RecuperarAsignaturas();
            }

            Asignaturas.RemoveAll(x => x.Clave == clave);
            GuardarAsignaturas();
        }

        #endregion
        #region Verificar
        public bool VerificarCarrera(string codigo)
        {
            bool exist = false;
            if (Carreras.Any(x => x.Codigo == codigo))
                exist = true;

            return exist;
        }

        public bool VerificarProfesor(long id)
        {
            bool exist = false;
            if (Profesores.Any(x => x.Id == id))
                exist = true;
            
            return exist;
        }

        public bool VerificarEstudiante(long id)
        {
            bool exist = false;
            if (Estudiantes.Any(x => x.Id == id))
                exist = true;
            
            return exist;
        }

        public bool VerificarAsignatura(string clave)
        {
            bool exist = false;
            if(Asignaturas.Any(x=>x.Clave==clave))
                exist = true;
            
            return exist;
        }
        #endregion

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            foreach (var est in Estudiantes.Where(x=>x.Id==estudiante.Id))
            {
                est.Asignaturas = estudiante.Asignaturas;
            }
            GuardarEstudiantes();
        }

        public void AsignarProfesor(string clave, long prof)
        {
            RecuperarEstudiantes();
            Asignaturas.Where(x => x.Clave == clave).ToList()[0].Profesor = Profesores.Where(x => x.Id == prof).ToList()[0];
            GuardarAsignaturas();
            foreach (var est in Estudiantes)
            {
                if (est.Asignaturas.Any(x => x.Clave == clave))
                {
                    est.Asignaturas.Where(x => x.Clave == clave).ToList()[0].Profesor = Profesores.Where(x => x.Id == prof).ToList()[0];
                }
                
            }
            GuardarEstudiantes();
        }

    }
}
