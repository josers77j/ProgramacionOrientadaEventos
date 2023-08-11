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
                //validacion del campo de texto
                if (!string.IsNullOrEmpty(NumeroTextBox.Text) && 
                    int.TryParse(NumeroTextBox.Text, out int numero) &&
                    numero>0)
                {
                    //es necesario definir las variables desde antes
                    string recorrido = "";
                    int sumatoria = 0;

                    for (int i = numero; i >= 1; i--)
                    {   //concatenando la variable i mientras se hace el recorrido
                        recorrido += $"{i}";
                        sumatoria += i;

                        // Agregar "+" si no es el último número
                        if (i > 1)
                        {
                            recorrido += " + ";
                        }
                    }
                    //Mostrar Mensajes
                    MessageBox.Show($"{recorrido} = {sumatoria}", "Sumatoria");
                    NumeroCapturadoLabel.Text = Convert.ToString(numero);
                    ResultadoLabel.Text = Convert.ToString(sumatoria);
                }
                else
                {
                    //cualquier cosa que no cumpla las condiciones, aqui.
                    MessageBox.Show("Unicamente valores de tipo enteros");
                    NumeroTextBox.Text = "";
                }
            }catch
            (Exception ex)
            {
                //si ocurre un error fuera de lo previsto, aqui.
                MessageBox.Show($"Error : {ex.Message}");
            }
        }
    }
}
