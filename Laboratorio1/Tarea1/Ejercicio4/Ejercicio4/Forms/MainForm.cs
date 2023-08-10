using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NumeroTextBox.Text) && 
                    int.TryParse(NumeroTextBox.Text, out int numero) &&
                    numero>0)
                {
                    for (int i = numero; i == 1; i--)
                    {

                    }                  
                }
                else
                {
                    MessageBox.Show("Letras, valores negativos o un valor cero, no son permitidos");
                    NumeroTextBox.Text = "";
                }
            }catch
            (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }
    }
}
