using Bidor.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidor.Dominio.Servicos
{
    public interface IAlunoServico
    {
        IQueryable<Aluno> Alunos();
    }
}
