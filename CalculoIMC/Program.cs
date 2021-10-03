using System;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            double imc = Math.Round((peso / Math.Pow(altura,2)), 2);
            string classificacao;
            if (imc < 18.5){
                classificacao = "Magreza";
            } else if (imc < 25){
                classificacao = "Normal";
            } else if (imc < 30){
                classificacao = "Sobrepeso";
            } else if (imc < 40){
                classificacao = "Obesidade";
            } else {
                classificacao = "Obesidade Grave";
            };
            Console.WriteLine($"Seu IMC é de {imc} classificado como {classificacao}");
        
        }


    }
}
