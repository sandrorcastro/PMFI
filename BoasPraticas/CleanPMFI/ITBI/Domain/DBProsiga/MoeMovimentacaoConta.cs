using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class MoeMovimentacaoConta
    {
        public long IdMoeMovimentacaoContas { get; set; }
        public long? IdMovEquipamento { get; set; }
        public long? IdObra { get; set; }
        public long? IdVeiculo { get; set; }
        public string? CdContaContabil { get; set; }
        public DateTime? DtMovimentacao { get; set; }
    }
}
