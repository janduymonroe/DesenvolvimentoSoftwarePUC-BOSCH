using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using wsteste.Models;

namespace wstesteFull.Dao
{
    public class PessoaDao
    {
        private readonly SqlConnection conexao;
        private readonly string stringConexao = "Server=localhost\\MSSQLSERVER01; Database=Pessoas; Trusted_Connection=true;";
        public PessoaDao(){
            conexao = new SqlConnection(stringConexao);
        }


        public async Task<List<Pessoa>> GetPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            string sqlQUery = "select * from Pessoas order by nome";
            await conexao.OpenAsync();
            SqlCommand comando = new SqlCommand(sqlQUery, conexao);
            SqlDataReader leitor = await comando.ExecuteReaderAsync();
           
            while (leitor.Read()){
                listaPessoas.Add(new Pessoa{
                    Nome = (string)leitor["nome"],
                    Cpf = (string)leitor["cpf"],
                    Idade = (int)leitor["idade"]
                });
            }

            await conexao.CloseAsync();
            return listaPessoas;

        }

        public async Task<Pessoa> GetByCpf(string cpf)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            string sqlQUery = "select * from Pessoas where cpf = @cpf";
            await conexao.OpenAsync();
            SqlCommand comando = new SqlCommand(sqlQUery, conexao);
            comando.Parameters.AddWithValue("@cpf", cpf);
            SqlDataReader leitor = await comando.ExecuteReaderAsync();
           
            while (leitor.Read()){
                if ((string)leitor["cpf"] == cpf){
                    Pessoa pessoa = new Pessoa(
                        (string)leitor["nome"],
                        (string)leitor["cpf"],
                        (int)leitor["idade"]
                    );
                    await conexao.CloseAsync();    
                    return pessoa;
                }
            }

            await conexao.CloseAsync();
            return null;

        }

        public async Task<bool> InsertPessoa(Pessoa pessoa)
        {
            string sqlQUery = "insert into Pessoas values (@nome, @cpf, @idade)";
            await conexao.OpenAsync();
            SqlCommand comando = new SqlCommand(sqlQUery, conexao);
            comando.Parameters.AddWithValue("@nome", pessoa.Nome);
            comando.Parameters.AddWithValue("@cpf", pessoa.Cpf);
            comando.Parameters.AddWithValue("@idade", pessoa.Idade);

            if (comando.ExecuteNonQuery() == 1){
                return true;
            }

            await conexao.CloseAsync();
            return false;

        }

        public async Task<bool> DeletePessoa(string cpf)
        {
            string sqlQUery = "delete from pessoas where cpf = @cpf";
            await conexao.OpenAsync();
            SqlCommand comando = new SqlCommand(sqlQUery, conexao);
            comando.Parameters.AddWithValue("@cpf", cpf);
            
            if (comando.ExecuteNonQuery() == 1){
                return true;
            }

            await conexao.CloseAsync();
            return false;

        }

         public async Task<bool> UpdatePessoa(string cpf, string nome, int idade)
        {
            string sqlQUery = "update Pessoas set nome = @nome, idade = @idade where cpf = @cpf;";
            await conexao.OpenAsync();
            SqlCommand comando = new SqlCommand(sqlQUery, conexao);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@idade", idade);

            if (comando.ExecuteNonQuery() == 1){
                return true;
            }

            await conexao.CloseAsync();
            return false;

        }


        
    }
}