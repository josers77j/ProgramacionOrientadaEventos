using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2.Forms
{
    public partial class Ejercicio2Form : Form
    {
        public Ejercicio2Form()
        {
            InitializeComponent();
        }

        private void calculateButton_MouseLeave(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(firstNumberTextBox.Text);
            int secondNumber = int.Parse(secondNumberTextBox.Text);

            int result = firstNumber + secondNumber;

            resultTextBox.Text = $"{result}";
        }
    }
}
