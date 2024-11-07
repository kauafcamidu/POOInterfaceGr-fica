using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_FORMS_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void calcularArea(object sender, EventArgs e)
        {
            Retagulo retangulo = new Retagulo(int.Parse(txtBase.Text), int.Parse(txtAltura.Text));
            lblResultado.Text = retangulo.CalcularArea().ToString();
        }

       
    }
}
