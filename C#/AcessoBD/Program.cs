using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace AcessoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConexao ="Server=localhost\\MSSQLSERVER01; Database=Sexta; Trusted_Connection=true;";

            SqlConnection conexao = new SqlConnection(strConexao);

            //Abrindo conexão com o banco de dados

            Console.Write("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            try{
                conexao.Open();

                string queryString = $"select * from aluno where nomeCompleto = @nomeCompleto;";

                SqlCommand comando = new SqlCommand(queryString, conexao);
                comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);

                SqlDataReader leitor = comando.ExecuteReader();
                bool verificaLeitor = leitor.Read();
                
                if(verificaLeitor)
                {
                    while(verificaLeitor){
                        string nome = (string)leitor["nomeCompleto"];
                        System.Console.WriteLine($"Nome: {nome}");
                        string telefone = (string)leitor["telefone"];
                        System.Console.WriteLine($"Telefone: {telefone}\n");
                        verificaLeitor = leitor.Read();
                    }
                } else {
                    leitor.Close();
                    Console.WriteLine("Nome não encontrado na base. Realizar cadastro.");
                    RealizarCadastro(conexao);
                    System.Console.WriteLine("Cadastro realizado com sucesso!");
                    
                }

            
            } catch (Exception e) {
                Console.WriteLine("Problemas ao estabelecer conexão.");
                System.Console.WriteLine(e.Message);
            
            } finally {
                if (conexao != null){
                    conexao.Close();
                    System.Console.WriteLine("Conexão finalizada.");
                }
            }
        }

        private static void RealizarCadastro(SqlConnection conexao){
            
            //String da inserção dos dados no banco de dados
            string stringQuery = "insert into aluno values (@nome, @dataNascimento, @sobrenome, @telefone);";
            
            //campos solicitados ao usuário
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.Write("Digite a sua data de nascimento no modelo 'yyyy-mm-dd': ");
            string dataNascimento = Console.ReadLine();
            Console.Write("Digite o seu telefone: ");
            string telefone = Console.ReadLine();
            
            //Abertura de comando, adição de parâmetros e execução
            SqlCommand comandoCadastro = new SqlCommand(stringQuery, conexao);
            comandoCadastro.Parameters.AddWithValue("@nome", nome);
            comandoCadastro.Parameters.AddWithValue("@sobrenome", sobrenome);
            comandoCadastro.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            comandoCadastro.Parameters.AddWithValue("@telefone", telefone);

            int resultado = comandoCadastro.ExecuteNonQuery();

            if(resultado<0)
                System.Console.WriteLine("Erro ao inserir dados.");    
        }
    }
}
