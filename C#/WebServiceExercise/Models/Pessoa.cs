using System;

namespace wsteste.Models
{
    public class Pessoa
    {
        public string Nome {get;set;}
        public string Cpf {get;set;}
        public int Idade {get;set;}

        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string cpf, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
        }
    }
}