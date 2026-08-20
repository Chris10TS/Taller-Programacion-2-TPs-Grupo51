using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Practico_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("¿Desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente: "+ textBox2.Text + " " + textBox3.Text +" se inserto Correctamente","Guardar", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    LModificar.Text = textBox2.Text + " " + textBox3.Text;
                }
            }
            else
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Esta apunto de eliminar el cliente " + LModificar.Text, "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("El cliente: " + LModificar.Text + " se elimino Correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RMujer.Checked == true)
            {
                // En C#, cambiamos Formulario_MDI.My.Resources por Properties.Resources
                pictureBox1.Image = Properties.Resources.Mujer;
            }
        }

        private void RHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (RHombre.Checked == true)
            {
                // En C#, cambiamos Formulario_MDI.My.Resources por Properties.Resources
                pictureBox1.Image = Properties.Resources.hombre;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }

        }
    }
}
