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
    public partial class Pequeño_Formulario : Form
    {
        public Pequeño_Formulario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            bool generoSeleccionado = Varon.Checked || Mujer.Checked;
            bool tarketaSeleccionada = CheckMastercard.Checked || CheckNaranja.Checked || CheckVisa.Checked;

            if (string.IsNullOrWhiteSpace(Tnombre.Text) || string.IsNullOrWhiteSpace(Tapellido.Text) || string.IsNullOrWhiteSpace(Tdni.Text) || string.IsNullOrWhiteSpace(Ttelefono.Text)|| !generoSeleccionado || !tarketaSeleccionada)
            {
                MessageBox.Show("Debe completar todos los campos", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tnombre.Focus();
                return;
            }
            else
            { ask = MessageBox.Show("Seguro que desea insertar un nuevo cliente?",
                "Confirmar insercion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

                if(ask == DialogResult.Yes)
                {
                    MessageBox.Show($"El Cliente: {Tnombre.Text} {Tapellido.Text} se inserto correctamente",
                        "guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    lmodificar.Text = $"{Tnombre.Text} {Tapellido.Text}";
                }

            }
        }

        private void Tdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask;

            ask = MessageBox.Show($"Esta a pundo de eliminar al cliente: {Tnombre.Text} {Tapellido.Text}",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                MessageBox.Show($"El cliente: {Tnombre.Text} {Tapellido.Text} se elimino correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Tdni.Clear();
                Tnombre.Clear();
                Tapellido.Clear();
                Ttelefono.Clear();
                CheckNaranja.Checked = false;
                CheckVisa.Checked = false;
                CheckMastercard.Checked = false;

                lmodificar.Text = "modificar";
            }
        }

        private void Pequeño_Formulario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckNaranja_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Varon_CheckedChanged(object sender, EventArgs e)
        {
            if (Varon.Checked)
            {
                pictureBox1.Image = Properties.Resources.Hombre;

            }
        }

        private void Mujer_CheckedChanged(object sender, EventArgs e)
        {
            if (Mujer.Checked)
            {
                pictureBox1.Image = Properties.Resources.Mujer;

            }
        }
    }
}
