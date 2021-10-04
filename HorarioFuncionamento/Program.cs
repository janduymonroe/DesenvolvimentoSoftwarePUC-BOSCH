using System;

namespace HorarioFuncionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o horário que deseja consultar: ");
            DateTime horario = Convert.ToDateTime(Console.ReadLine());
            string situacao;
            if (horario.Hour == 7 && horario.Minute >= 30){
                situacao = "Aberto";
            } else if (horario.Hour == 23 && horario.Minute <= 30){
                situacao = "Aberto";
            } else if (horario.Hour > 7 && horario.Hour < 23){
                situacao = "Aberto";
            } else {
                situacao = "Fechado";
            };
            System.Console.WriteLine(situacao);
        }
    }
}
