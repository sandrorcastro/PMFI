using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Orgao
    {
        public int OrgaoId { get; set; }
        public string? Descricao { get;}
        public virtual ICollection<Unidade>? Unidades { get; set; }
     //   public ICollection<Processo> Processos { get; set; }
        //public virtual ICollection<Processo>? ProcessosEmitidos { get; set; }
        //public virtual ICollection<Processo>? ProcessosRecebidos { get; set; }

    }
}
