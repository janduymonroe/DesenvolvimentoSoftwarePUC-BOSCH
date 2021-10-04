using System;

namespace IdadeEmMeses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua data de nascimento (mm/dd/aaaa): ");
            DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
            DateTime dataAtual = DateTime.Now;
            int dataDiferenca = ((dataAtual.Year-dataNascimento.Year) * 12 + dataAtual.Month - dataNascimento.Month);
            Console.WriteLine("Você tem {0} meses de vida.", (dataDiferenca));
            
        }
    }
}
