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
        public bool calificada=false;
        uint calificacion;
        AlfaCalificacion alfacalificacion=AlfaCalificacion.N;
        public uint PuntosHonor;
        public uint ValorNota;

        public string Clave { get => clave; set => clave = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }       
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public uint Calificacion
        {
            get
            {
                return calificacion;
            }

            set
            {
                if (value > 100)
                    throw new Exception("Calificacion no valida");
                else if (value > 89)
                {
                    alfacalificacion = AlfaCalificacion.A;
                    ValorNota = 4;
                }               
                else if (value > 79)
                {
                    alfacalificacion = AlfaCalificacion.B;
                    ValorNota = 3;
                }
                else if (value > 69)
                {
                    alfacalificacion = AlfaCalificacion.C;
                    ValorNota = 2;
                }
                else if (value > 59)
                {
                    alfacalificacion = AlfaCalificacion.D;
                    ValorNota = 1;
                }
                else
                {
                    alfacalificacion = AlfaCalificacion.F;
                    ValorNota = 0;
                }
                calificacion = value;
                GetPuntosHonor();
            }
        }
        public uint Creditos { get => creditos; set => creditos = value; }
        public AlfaCalificacion Alfacalificacion { get => alfacalificacion; set => alfacalificacion = value; }

        public Asignatura(string clave, string descripcion, uint creditos)
        {
            this.clave = clave;
            this.descripcion = descripcion;
            this.creditos = creditos;
        }

        void GetPuntosHonor()
        {
            PuntosHonor = creditos * ValorNota;
        }

    }

    public enum AlfaCalificacion { A, B, C, D, F, N};
}
