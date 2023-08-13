using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.Forms
{
    public partial class DiasHorasForm : Form
    {
        public DiasHorasForm()
        {
            InitializeComponent();
        }

        private void diasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números enteros");
            }
            else
            {
                resultadoHorasLabel.Text = "Cuando ingrese el número presione el botón convertir para ver el resultado.";
            }
        }

        private void convertirDiasHorasButton_Click(object sender, EventArgs e)
        {
            int dias = int.Parse(diasTextBox.Text);
            int horas = dias * 24;
            resultadoHorasLabel.Text = $"                                           La cantidad de horas son:    {horas}";
        }
    }
}
