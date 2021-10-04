using System;
using System.Globalization;

namespace PrecoVendaProdutoPorQuilo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade em Kg que deseja: ");
            double quantidade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o preço por Kg: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            double total = quantidade*preco;
            Console.WriteLine($"O valor total da venda é {total.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        }
    }
}
