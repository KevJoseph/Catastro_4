using Catastro_4.Basedatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catastro_4.Enity
{
    class Propietario
    {
        public string codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Propietario() { }

        public Propietario(string codigo, string nombre, string apellido)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }    
    
}
