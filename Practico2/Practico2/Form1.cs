using System;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Validación TDni: solo números y tecla de borrado
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validación TApellido: solo letras, espacios y borrado
        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validación TNombre: solo letras, espacios y borrado
        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Botón Guardar
        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LModificar.Text = TApellido.Text + " " + TNombre.Text;

            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?",
                                               "Confirmar insercion",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button1);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Cliente: " + LModificar.Text + " se insertó Correctamente",
                                "Guardar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        // Botón Eliminar
        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDni.Text) &&
                string.IsNullOrWhiteSpace(TApellido.Text) &&
                string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("No hay datos para eliminar", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult ask = MessageBox.Show("Está a punto de eliminar el Cliente: " + LModificar.Text,
                                               "Confirmar Eliminacion",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning,
                                               MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {
                string clienteEliminado = LModificar.Text;

                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                LModificar.Text = "modificar";

                MessageBox.Show("El Cliente: " + clienteEliminado + " se eliminó correctamente",
                                "Eliminar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}