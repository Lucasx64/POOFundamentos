using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace POO___Fundamentos
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;

        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para realizar o saque de R$ {valor:F2}.");
            }
        }
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para realizar o saque de R$ {valor:F2}.");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {Titular} | Saldo atual: R$ {Saldo:F2}");
        }





    }
}
