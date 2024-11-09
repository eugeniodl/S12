using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeReservas
{
    public partial class FormReservar : Form
    {
        public FormReservar()
        {
            InitializeComponent();
        }

        private void mtbTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbTelefono.MaskCompleted)
            {
                MessageBox.Show("Por favor, complete el número de teléfono en el formato correcto.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void mtbTelefono_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Número de teléfono válido ingresado.", "Validación exitosa",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
