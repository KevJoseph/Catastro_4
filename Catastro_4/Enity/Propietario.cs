using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catastro_4.Enity
{
    class Propietario
    {
        private string codigo { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        public Propietario() { }

        public Propietario(string codigo, string nombre, string apellido)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }

}
