using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidor.Dados.Entidades
{
    public class Turma
    {
        public int Id { get; set; }
        public short Ano { get; set; }
        public short Semestre { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public Materia Materia { get; set; }
    }
}
