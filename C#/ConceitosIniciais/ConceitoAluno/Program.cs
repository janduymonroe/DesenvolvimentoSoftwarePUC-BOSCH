using System;

namespace ConceitoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double presenca;
            Console.WriteLine("Digite a nota do aluno: ");
            nota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a frequência do aluno em %: ");
            presenca = Convert.ToDouble(Console.ReadLine());
            if (presenca > 70){
                if (nota > 9)
                System.Console.WriteLine($"Conceito A");
                else if (nota > 8)
                System.Console.WriteLine($"Conceito B");
                else if (nota > 7)
                System.Console.WriteLine($"Conceito C");
                else if (nota > 6)
                System.Console.WriteLine($"Conceito D");
                else if (nota > 4)
                System.Console.WriteLine($"Conceito E");
                else
                System.Console.WriteLine($"Conceito F");
            } else {
                System.Console.WriteLine("Você não possui frequência suficiente para obter conceito.");
            }
        }
    }
}
