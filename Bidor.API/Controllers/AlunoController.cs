using Bidor.Dados.Entidades;
using Bidor.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bidor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : Controller
    {
        private readonly IAlunoServico _alunoServico;

        public AlunoController(IAlunoServico alunoServico)
        {
            _alunoServico = alunoServico;
        }

        [HttpGet]
        public IEnumerable<Aluno> Index()
        {
            return _alunoServico.Alunos().ToList();
        }

        [HttpPost]
        public IActionResult Inserir([FromBody] Aluno aluno)
        {
            var alunoInserido = _alunoServico.Inserir(aluno);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, [FromBody] Aluno aluno)
        {
            var alunoInserido = _alunoServico.Alterar(id,aluno);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            bool excluido= _alunoServico.Excluir(id);
            return Ok();
        }

    }
}
