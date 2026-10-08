using System;
using System.Collections.Generic;
using System.Text;

namespace POO___Fundamentos
{
    public class Carro
    {
        // Atributos
        public string Marca;
        public string Modelo;
        public int Ano;


        // Métodos
        // Mostrar as informações do carro:
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }



    }
}
