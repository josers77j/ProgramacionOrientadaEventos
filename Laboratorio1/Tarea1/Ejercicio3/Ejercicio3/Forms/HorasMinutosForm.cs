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
    public partial class HorasMinutosForm : Form
    {
        public HorasMinutosForm()
        {
            InitializeComponent();
        }

        private void horasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números enteros");
            }
            else
            {
                resultadoMinutosLabel.Text = "Cuando ingrese el número presione el botón convertir para ver el resultado.";
            }
        }

        private void convertirHorasMinutosButton_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(horasTextBox.Text);
            int minutos = horas * 60;
            resultadoMinutosLabel.Text = $"                                       La cantidad de minutos son:    {minutos}";
        }
    }
}
