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
    public partial class MinutosSegundosForm : Form
    {
        public MinutosSegundosForm()
        {
            InitializeComponent();
        }

        private void minutosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números enteros");
            }
            else
            {
                resultadoSegundosLabel.Text = "Cuando ingrese el número presione el botón convertir para ver el resultado.";
            }
        }

        private void convertirMinutosSegundosButton_Click(object sender, EventArgs e)
        {
            int minutos = int.Parse(minutosTextBox.Text);
            int segundos = minutos * 60;
            resultadoSegundosLabel.Text = $"                                        La cantidad de segundos son:    {segundos}";
        }
    }
}
