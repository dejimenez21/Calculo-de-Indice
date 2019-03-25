using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Calculo_de_Indice
{
    class Asignatura
    {
        string clave;
        string descripcion;
        Profesor profesor = new Profesor();
        string calificacion;

        public string Clave { get => clave; set => clave = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Calificacion { get => calificacion; set => calificacion = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }


    }

    
}
