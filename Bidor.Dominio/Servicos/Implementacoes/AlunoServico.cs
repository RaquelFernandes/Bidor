using Bidor.Dados;
using Bidor.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidor.Dominio.Servicos.Implementacoes
{
    public class AlunoServico : IAlunoServico
    {
        private readonly Contexto _contexto;

        public AlunoServico(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IQueryable<Aluno> Alunos()
        {
            return _contexto.Aluno;
        }
    }
}
