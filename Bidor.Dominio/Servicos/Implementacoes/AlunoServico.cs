using Bidor.Dados;
using Bidor.Dados.Entidades;
using System.Linq;

namespace Bidor.Dominio.Servicos.Implementacoes
{
    public class AlunoServico : IAlunoServico
    {
        private readonly Contexto _contexto;

        public AlunoServico(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Aluno Alterar(int id, Aluno aluno)
        {
            _contexto.Aluno.Update(aluno);
            _contexto.SaveChanges();
            return aluno;
        }

        public IQueryable<Aluno> Alunos()
        {
            return _contexto.Aluno;
        }

        public bool Excluir(int id)
        {
            var aluno = _contexto.Find<Aluno>(id);
            _contexto.Aluno.Remove(aluno);
            return _contexto.SaveChanges() > 0;
        }

        public Aluno Inserir(Aluno aluno)
        {
            _contexto.Aluno.Add(aluno);
            _contexto.SaveChanges();
            return aluno;
        }
    }
}
