using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual operação matemática você quer realizar (+, -, *, /)? ");
            string operacao = Console.ReadLine();
            Console.Write("Qual o número gostaria de ver a tabuada?  ");
            double numero = Convert.ToDouble(Console.ReadLine());
            if (operacao == "+"){
                for (int i = 0; i < 11; i++){
                    Console.WriteLine($"{i}+{numero}={numero+i}");
                }
            } else if (operacao == "-"){
                for (int i = 0; i < 11; i++){
                    Console.WriteLine($"{i}-{numero}={numero-i}");
                }
            } else if (operacao == "*"){
                for (int i = 0; i < 11; i++){
                    Console.WriteLine($"{i}*{numero}={numero*i}");
                }
            } else if (operacao == "/"){
                for (int i = 1; i < 11; i++){
                    Console.WriteLine($"{numero*i}/{numero}={i}");
                }
            }
        }
    }
}
