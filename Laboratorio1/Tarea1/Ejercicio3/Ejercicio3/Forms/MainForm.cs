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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void convertirDiasHorasButton_Click(object sender, EventArgs e)
        {
            DiasHorasForm diasHorasForm = new DiasHorasForm();
            diasHorasForm.ShowDialog();
        }

        private void convertirHorasMinutosButton_Click(object sender, EventArgs e)
        {
            HorasMinutosForm horasMinutosForm = new HorasMinutosForm();
            horasMinutosForm.Show();
        }

        private void convertirMinutosSegundosButton_Click(object sender, EventArgs e)
        {
            MinutosSegundosForm minutosSegundosForm = new MinutosSegundosForm();
            minutosSegundosForm.ShowDialog();
        }
    }
}
