using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidor.Dados.Entidades
{
    public class Atividade
    {
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public TipoDeAtividade TipoDeAtividade { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public DateTime? DataDaAtividade { get; set; }
        public float PontosObtidos { get; set; }
    }
}
