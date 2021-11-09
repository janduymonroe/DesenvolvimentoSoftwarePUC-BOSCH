using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using wsteste.Models;
using wstesteFull.Dao;

namespace wsteste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaDao pessoaDao = new PessoaDao();

        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> GetTodasPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = await pessoaDao.GetPessoas();
            if(pessoas.Count > 0){
                return Ok(pessoas);
            }
            return NotFound("Pessoas não encontradas");
        }

        [HttpGet("byNome")]
        public async Task<ActionResult<List<Pessoa>>> GetByNome([FromQuery(Name="name")] string nome)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = await pessoaDao.GetPessoas();
            for (int i = 0; i < pessoas.Count; i++){
                if(pessoas[i].Nome != nome){
                    pessoas.RemoveAt(i);
                }
            }
            if(pessoas.Count > 0){
                return Ok(pessoas);
            }

            return NotFound("Nenhuma pessoa com o nome encontrada.");
        }

       [HttpGet("byCpf")]
        public async Task<ActionResult<List<Pessoa>>> GetByCpf([FromQuery(Name="cpf")] string cpf)
        {
            Pessoa pessoa = new Pessoa();
            pessoa = await pessoaDao.GetByCpf(cpf);
            
            if (pessoa != null){
                return Ok(pessoa);
            }

            return NotFound("Nenhuma pessoa com o cpf encontrada.");
        }

        [HttpPost("{nome}/{cpf}/{idade}")]
        public async Task<ActionResult> InserirPessoa(string nome, string cpf, int idade)
        {
            Pessoa p = await pessoaDao.GetByCpf(cpf);
            if (p != null){
                return BadRequest("Pessoa já cadastrada.");
            }
            Pessoa pessoa = new Pessoa(nome,cpf,idade);
            await pessoaDao.InsertPessoa(pessoa);
            
            return Ok("Pessoa inserida com sucesso");
        }

        [HttpDelete("{cpf}")]
        public async Task<ActionResult> DeletarPessoa(string cpf)
        {
            Pessoa p = await pessoaDao.GetByCpf(cpf);
            if (p == null){
                return BadRequest("Pessoa não existe.");
            }
            
            await pessoaDao.DeletePessoa(cpf);
            
            return Ok("Pessoa excluída com sucesso.");
        }

        [HttpPost("{cpf}")]
        public async Task<ActionResult> UpdatePessoa(string cpf, string nome,  int idade)
        {
            Pessoa p = await pessoaDao.GetByCpf(cpf);
            if (p == null){
                return BadRequest("Pessoa não existe.");
            }
            if (nome == null){
                await pessoaDao.UpdatePessoa(p.Cpf, nome = p.Nome, idade);
                return Ok("Alteração realizada com sucesso.");
            } else if (idade == 0){
                await pessoaDao.UpdatePessoa(p.Cpf, nome, idade = p.Idade);
                return Ok("Alteração realizada com sucesso.");
            }          
            await pessoaDao.UpdatePessoa(cpf, nome, idade);
            
            return Ok("Pessoa inserida com sucesso");
        }




        
        
    }
}
