using System;
using System.Collections.Generic;
using System.Text;

namespace POO___Fundamentos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá, {outraPessoa}! Eu sou {Nome}");
        }

        public string ObterApresentacao()
        {
            return $"Meu nome é {Nome}.";
        }

    }

}
