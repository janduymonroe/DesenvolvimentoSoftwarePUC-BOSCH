using System;
using Carro;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.ano = 2020;
            carro1.cor = "branco";
            carro1.marca = "Ferrari";
            carro1.placa = "NMZ-6566";
            Console.WriteLine("Ligando o Motor...");
            carro1.ligarMotor();
            Console.WriteLine("Acelerando...");
            carro1.acelerar();
            Console.WriteLine("Desligando o carro...");
            carro1.desligarMotor();
            Console.WriteLine("Acelerando o carro...");
            carro1.acelerar();
            Console.WriteLine(carro1.ToString());

        }
    }
}
