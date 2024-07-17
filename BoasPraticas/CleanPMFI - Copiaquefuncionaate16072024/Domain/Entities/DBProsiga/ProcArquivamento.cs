using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ProcArquivamento
    {
        public ProcArquivamento()
        {
            Processos = new HashSet<Processo>();
        }

        public long ArquivId { get; set; }
        public long? ArqLocalFisicoId { get; set; }
        public long? ArqArmario { get; set; }
        public long? ArqPrateleira { get; set; }
        public long? ArqCaixa { get; set; }

        public virtual LocalFisico? ArqLocalFisico { get; set; }
        public virtual ICollection<Processo> Processos { get; set; }
    }
}
