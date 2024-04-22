using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FissComprovante
    {
        public FissComprovante()
        {
            FissCompDivida = new HashSet<FissCompDividum>();
            FissComprovanteItens = new HashSet<FissComprovanteIten>();
        }

        public long CompId { get; set; }
        public DateTime? CompData { get; set; }
        public long? EmprCmc { get; set; }
        public long? ConId { get; set; }
        public long? ContadorId { get; set; }
        public string? CompSituacao { get; set; }
        public string? CompSituacaoCanc { get; set; }

        public virtual ICollection<FissCompDividum> FissCompDivida { get; set; }
        public virtual ICollection<FissComprovanteIten> FissComprovanteItens { get; set; }
    }
}
