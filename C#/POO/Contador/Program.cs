using System;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            Contador contador = new Contador();
            contador.valor = 30;
            contador.incrementar();
            contador.incrementar();
            contador.incrementar();
            contador.incrementar();
            contador.incrementar();
            contador.incrementar();
            contador.zerar();
            contador.incrementar();
            contador.incrementar();
            contador.incrementar();
            Console.WriteLine(contador.ToString());
        }
    }
}
