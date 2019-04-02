using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Carrera
    {
        string codigo;
        string descripcion;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Carrera()
        {

        }
        public Carrera(string codigo)
        {
            this.codigo = codigo;
        }

        public Carrera(string codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
    }
}
