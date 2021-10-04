using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A partir de qual escala deseja realizar a conversão:\n1 - Celsius(C)\n2 - Fahrenheit(F)\n3 - Kelvin(K)\nDigite sua opção: ");
            int escalaInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual valor você deseja converter: ");
            double valorInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Para qual escala deseja realizar a conversão:\n1 - Celsius(C)\n2 - Fahrenheit(F)\n3 - Kelvin(K)\nDigite sua opção: ");
            int escalaFinal = Convert.ToInt32(Console.ReadLine());
            double valorFinal = CalcTemp(escalaInicial, valorInicial, escalaFinal);
            string escala = Escala(escalaFinal);
            Console.Write($"O valor convertido é de {valorFinal}{escala}");
        }

        public static double CalcTemp (int escalaInicial, double valorInicial, int escalaFinal){
            if (escalaInicial == 1){
                if (escalaFinal == 2){
                    return TempCToF(valorInicial);
                } else {
                    return TempCToK(valorInicial);
                };
            } else if (escalaInicial == 2){
                if (escalaFinal == 1){
                    return TempFToC(valorInicial);
                } else {
                    return TempCToK(valorInicial);
                };
            } else{
                if (escalaFinal == 1){
                    return TempKToC(valorInicial);
                } else {
                    return TempKToF(valorInicial);
                };
            }
        }

        public static string Escala (int escalaFinal){
            if (escalaFinal == 1){
                return "ºC";
            } else if (escalaFinal == 2){
                return "ºF";
            } else {
                return "K";
            }
        }

        public static double TempCToF (double valorInicial){
            return valorInicial * 1.8 + 32;
        }

        public static double TempCToK (double valorInicial){
            return valorInicial + 273;
        }

        public static double TempFToK (double valorInicial){
            return (valorInicial - 32 ) * 5/9 + 273;
        }

        public static double TempFToC (double valorInicial){
            return (valorInicial - 32)/1.8;
        }

        public static double TempKToC (double valorInicial){
            return valorInicial - 273;
        }

        public static double TempKToF (double valorInicial){
            return (valorInicial - 273) * 1.8 + 32;
        }

    }
}


