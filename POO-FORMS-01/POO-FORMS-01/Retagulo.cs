using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_FORMS_01
{
    internal class Retagulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retagulo(double baseRetangulo, double alturaRetangulo)
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
