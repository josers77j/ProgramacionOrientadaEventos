using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void numeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números enteros");
            }
            else
            {
                resultadoLabel.Text = "Cuando ingrese el número presione el botón calcular para ver el resultado.";
            }
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(numeroTextBox.Text);
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            resultadoLabel.Text = $"                                            El factorial de {numero} es:    {factorial}";
        }
    }
}
