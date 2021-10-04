using System;

namespace CategoriaBoxe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o peso do lutador: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            string categoria;
            if (peso < 50){
                categoria = "Palha";
            }  else if (peso < 60){
                categoria = "Pluma";
            } else if (peso < 76){
                categoria = "Leve";
            } else if (peso < 88){
                categoria = "Pesado";
            } else {
                categoria = "Super Pesado";
            }
            System.Console.WriteLine("A categoria do lutador é {0}", categoria);
        }
    }
}
