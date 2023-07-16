using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalificacionEstudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, suma, resultado;
            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            nota3 = double.Parse(txtNota3.Text);
            nota4 = double.Parse(txtNota4.Text);
            suma = nota1+nota2+nota3 +nota4;
            resultado = suma / 4;
            lblResultado.Text = resultado.ToString();
            label6.Visible = true;
            lblResultado.Visible = true;
            

        }
    }
}
