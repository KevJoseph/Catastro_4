using Catastro_4.Basedatos;
using Catastro_4.Model;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Catastro_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            bd.conexion.Open();
            
            SqlCommand cmd = bd.conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nombre, apellido, numFicha, CodCont, coopre, TipHab, NomHab, RUC, Sector, Mz, Lt FROM dbo.Propietarios WHERE codigo like ('" + txtcodigo.Text + "%')";
            cmd.ExecuteNonQuery();
            
            SqlDataReader leer = cmd.ExecuteReader();

            while (leer.Read() == true)
            {
                txtNombre.Text = leer["nombre"].ToString();
                txtApellido.Text = leer["apellido"].ToString();
                txtNFicha.Text = leer["numFicha"].ToString();
                txtCodCont.Text = leer["CodCont"].ToString();
                txtCoopre.Text = leer["coopre"].ToString();
                txtTipHab.Text = leer["TipHab"].ToString();
                txtNomHab.Text = leer["NomHab"].ToString();
                txtRuc.Text = leer["RUC"].ToString();
                txtSector.Text = leer["Sector"].ToString();
                txtMz.Text = leer["Mz"].ToString();
                txtLt.Text = leer["Lt"].ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ModelPropietario mp = new ModelPropietario();
            mp.SelectPropietario();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
