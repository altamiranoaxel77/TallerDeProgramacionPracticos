using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2TrabajosPracticos
{
    public partial class Practico1 : Form
    {
        public Practico1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            TxtventanaResultado.Text = $"{nombre} {apellido}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  