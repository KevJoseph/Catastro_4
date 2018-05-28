using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catastro_4.Basedatos
{
    class BaseDatos
    {
        // coloca tus datos de tu equipo ( que va actuar como servidor)
        private string servidor = "Informatica\\SQLEXPRESS";
        private string data_base = "BD_CATASTRO_PUNTA_HERMOSA";
        private string cadena="";
        public SqlConnection conexion;

        public BaseDatos()
        {
            cadena = "Data Source=" + this.servidor+";Initial Catalog="+this.data_base+ "; Integrated Security=True; UID=vek-PC;PWD=qwerty";
            conexion = new SqlConnection(cadena);
        }

        public void open()
        {
            
            try
            {
                conexion.Open();
                
                MessageBox.Show("Conexion abierta con la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
               
            }

        }

        public void close()
        {
            this.conexion.Close();
        }

        public string getSource()
        {
            return this.cadena;
        }
        public SqlConnection con()
        {
            return this.conexion;
        }
    }
}
