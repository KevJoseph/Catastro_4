using Catastro_4.Basedatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catastro_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
           
=======
        private void Form1_Load(object sender, EventArgs e)
        {
            BaseDatos bd = new BaseDatos();
            bd.open();
>>>>>>> 79c16d721ce9aa29d2c8f2241783df40bdc75f69
        }
    }
}
