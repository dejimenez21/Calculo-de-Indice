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
        public Carrera carrera { get => Carrera; set => Carrera = value; }
        public List<Asignatura> Asignaturas { get => asignaturas; set => asignaturas = value; }
        public double Indice;
        public uint TotalCreditos;
        public uint TotalPuntosHonor;
        public string Honor;
        public bool Estatus=true;

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
            
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            asignaturas.Add(asignatura);
        }

        public bool IsSeleccionada(string clave)
        {
            return asignaturas.Any(x => x.Clave == clave);
        }

        public double GetIndice()
        {
            TotalCreditos = 0;
            TotalPuntosHonor = 0;

            foreach(Asignatura asignatura in asignaturas.Where(x=>x.calificada))
            {
                TotalCreditos += asignatura.Creditos;
                TotalPuntosHonor += asignatura.PuntosHonor;
            }
            if (TotalCreditos != 0)
            {
                Indice = TotalPuntosHonor / (double)TotalCreditos;
            }
            Indice = Math.Round(Indice, 2);

            if (Indice > 3.79)
            {
                Honor = "Summa Cum Laude";
            }
            else if (Indice > 3.59)
            {
                Honor = "Magna Cum Laude";
            }
            else if (Indice > 3.39)
            {
                Honor = "Cum Laude";
            }
            else
            {
                Honor = "Sin Honor";
            }
            return Indice;
        }
    }
}
