using Catastro_4.Basedatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catastro_4.Model
{
    class ModelPropietario
    {
        public BaseDatos bd;

        public ModelPropietario()
        {
            this.bd = new BaseDatos();
           
        }

        public ArrayList SelectPropietario()
        {
            ArrayList lista = new ArrayList();
            
            try
            {
                using (this.bd.con())
                {
                    this.bd.open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PROPIETARIOS;");

                    // int result = command.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show(String.Format("{0}", reader["codigo"]));
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: "+ex);
                return null;
            }
            
        }

    }
}
