using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SaudeReceitaItem
    {
        public int Idreceita { get; set; }
        public int Idmedicamento { get; set; }
        public int Removido { get; set; }
        public int QtdeSolicitada { get; set; }
        public int? QtdeRetirada { get; set; }
        public string? ModoUso { get; set; }
        public int? DuracaoTratamento { get; set; }
        public DateTime? DtProximaRetiradaAtualizada { get; set; }
        public int? IditemReceita { get; set; }

        public virtual SaudeMedicamentoXxxxxx IdmedicamentoNavigation { get; set; } = null!;
        public virtual SaudeReceitum IdreceitaNavigation { get; set; } = null!;
    }
}
