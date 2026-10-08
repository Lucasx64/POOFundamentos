using System;
using System.Collections.Generic;
using System.Text;

namespace POO___Fundamentos
{
    internal class Lampada
    {
        public bool Ligada;

        public void Ligar()
        {
            Ligada = true;
        }
        public void Desligar()
        {
            Ligada = false;
        }
        public void Alternar()
        {
            Ligada = !Ligada;
        }
        public void ExibirEstado()
        {
            if (Ligada)
            {
                Console.WriteLine("A lâmpada está ligada.");
            }
            else
            {
                Console.WriteLine("A lâmpada está desligada.");
            }
        }
    }
}
