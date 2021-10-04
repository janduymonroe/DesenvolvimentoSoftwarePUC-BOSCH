using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano do seu nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            int dataAtual = DateTime.Now.Year;
            int idade = dataAtual - anoNascimento;
            System.Console.WriteLine($"Você tem {idade} anos.");
        }
    }
}
