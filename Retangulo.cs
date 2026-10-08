using System;
using System.Collections.Generic;
using System.Text;

namespace POO___Fundamentos
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
