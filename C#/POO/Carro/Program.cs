using System;
using Carro;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.ligarMotor();
            carro1.acelerar();
            carro1.desligarMotor();
            carro1.acelerar();

        }
    }
}
