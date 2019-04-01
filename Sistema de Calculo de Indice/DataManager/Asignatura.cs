using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Asignatura
    {
        string clave;
        string descripcion;
        Profesor profesor = new Profesor();
        uint creditos;
        AlfaCalificacion calificacion;

        public string Clave { get => clave; set => clave = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }       
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public string Calificacion
        {
            get
            {
                return calificacion.ToString();
            }

            set
            {
                if (uint.Parse(value) > 100)
                    throw new Exception("Calificacion no valida");
                else if (uint.Parse(value) > 89)
                    calificacion = AlfaCalificacion.A;
                else if (uint.Parse(value) > 79)
                    calificacion = AlfaCalificacion.B;
                else if (uint.Parse(value) > 69)
                    calificacion = AlfaCalificacion.C;
                else if (uint.Parse(value) > 59)
                    calificacion = AlfaCalificacion.D;
                else
                    calificacion = AlfaCalificacion.F;
            }
        }
        public uint Creditos { get => creditos; set => creditos = value; }
    }

    public enum AlfaCalificacion { A, B, C, D, F, N};
}
