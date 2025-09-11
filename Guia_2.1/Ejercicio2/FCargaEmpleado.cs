using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FCargaEmpleado : Form
    {
        public FCargaEmpleado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   /*
            if(string.IsNullOrEmpty(tbNombre.Text)) { MessageBox.Show("Completar NOmbre "); btnAceptar.DialogResult = DialogResult.Cancel ; }
            if(string.IsNullOrEmpty(tbApellido.Text)) { MessageBox.Show("Completar Apellido "); btnAceptar.DialogResult = DialogResult.Cancel; }
            if (string.IsNullOrEmpty(tbDNI.Text)) { MessageBox.Show("Completar DNI"); btnAceptar.DialogResult = DialogResult.Cancel; }
            */
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un dígito o un carácter de control (como Backspace, Delete, Enter)
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true; // Evita que se escriba el carácter
            }
        }
    }
}
