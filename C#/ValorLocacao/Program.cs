using System;
using System.Globalization;

namespace ValorLocacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorLocacao = 100.00;
            Console.Write("Digite a quantidade de dias você deseja alugar o carro: ");
            int diarias = Convert.ToInt32(Console.ReadLine());
            double valorTotal = valorLocacao * diarias;
            System.Console.WriteLine($"O valor total da sua locação é de {valorTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        }
    }
}
