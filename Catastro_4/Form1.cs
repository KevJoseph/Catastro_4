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
            cmd.CommandText = "select cTIPOTIT, cNUMFICHA, cCODCONTRI, cNDOCTIT, cNOMTIT, cAPPATIT, cCODPRE, cTipHab, cNOMHAB, cSECTOR, cMZA, cLOTE FROM IND_FICHA WHERE cTIPOTIT=1 and cCODPRE='" + txtcodigo.Text + "' and cActivo=1";
           
            cmd.ExecuteNonQuery();
            
            SqlDataReader leer = cmd.ExecuteReader();

            MessageBox.Show(leer["cNOMTIT"].ToString());

            while (leer.Read() == true)
                {
                    txtNombre.Text = leer["cNOMTIT"].ToString();
                    txtApellido.Text = leer["cAPPATIT"].ToString();
                    txtNFicha.Text = leer["cNUMFICHA"].ToString();
                    txtCodCont.Text = leer["cCODCONTRI"].ToString();
                    txtCoopre.Text = leer["cCODPRE"].ToString();
                    txtTipHab.Text = leer["cTipHab"].ToString();
                    txtNomHab.Text = leer["cNOMHAB"].ToString();
                    //txtRuc.Text = leer["RUC"].ToString();
                    txtSector.Text = leer["cSECTOR"].ToString();
                    txtMz.Text = leer["cMZA"].ToString();
                    txtLt.Text = leer["cLOTE"].ToString();


                    //dataGridView1.Rows.Add(leer[0].ToString(), leer[1].ToString());

                }
           
            bd.conexion.Close();
            bd.conexion.Open();

            SqlCommand cmd2 = bd.conexion.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT  nAREDECCON, nAREVERCON FROM  IND_CONPRE where cNUMFICHA='" + txtNFicha.Text + "'";
            cmd2.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            
            bd.conexion.Close();
            bd.conexion.Open();

            SqlCommand cmd3 = bd.conexion.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select sum(nAREDECCON),sum(nAREVERCON) FROM IND_CONPRE WHERE cNUMFICHA='" + txtNFicha.Text + "'";
            cmd3.ExecuteNonQuery();

            SqlDataReader leer1 = cmd3.ExecuteReader();
            while (leer1.Read() == true)
            {
                suma1.Text = leer1[0].ToString();
                suma2.Text = leer1[1].ToString();
            }

            bd.conexion.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
