using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catastro_4.Basedatos
{
    class BaseDatos
    {
        // coloca tus datos de tu equipo ( que va actuar como servidor)
        private string servidor = "Informatica\\SQLEXPRESS";
        private string data_base = "catastro_Demo";
        private string cadena;
        public SqlConnection conexion = new SqlConnection();

        public BaseDatos()
        {
            this.cadena = "Data Source="+this.servidor+";Initial Catalog="+this.data_base+"; Integrated Security=True";
        }

        public void Open()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta con la base de datos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos.");
            }

        }

        public void close()
        {
            conexion.Close();
        }
    }
}
