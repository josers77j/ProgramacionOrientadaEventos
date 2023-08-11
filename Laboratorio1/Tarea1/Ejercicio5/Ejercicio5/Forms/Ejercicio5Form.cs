using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5.Forms
{
    public partial class Ejercicio5Form : Form
    {
        public Ejercicio5Form()
        {
            InitializeComponent();
        }

        private void CompararButton_Click(object sender, EventArgs e)
        {  
            try
            {   //compruebo si hay algo en el textbox
                if (!string.IsNullOrEmpty(PrimerNumeroTextBox.Text) && !string.IsNullOrEmpty(SegundoNumeroTextBox.Text))
                {
                    //compruebo si los campos introducidos son numeros
                    if(int.TryParse(PrimerNumeroTextBox.Text, out int PrimerNumero) &&
                        int.TryParse(SegundoNumeroTextBox.Text, out int SegundoNumero))
                    {
                        //comprobamos si ambos numeros son iguales
                        if (PrimerNumero == SegundoNumero)
                        {
                            MessageBox.Show("Ambos numeros son iguales");
                        }
                        else
                        {
                            MessageBox.Show("Ambos numeros son diferentes");
                        }
                    }else
                    {
                        MessageBox.Show("Los datos a introducir deben ser unicamente numeros de tipo entero");
                    }
                }
                else
                {
                    MessageBox.Show("Uno o dos campos estan vacios");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}" );
            }
        }
    }
}
