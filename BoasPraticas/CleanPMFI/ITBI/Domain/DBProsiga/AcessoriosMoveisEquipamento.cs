using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AcessoriosMoveisEquipamento
    {
        public AcessoriosMoveisEquipamento()
        {
            MoeMovEquips = new HashSet<MoveisEquipamento>();
        }

        public long AcesMovEquipId { get; set; }
        public long? AcesFornecedorId { get; set; }
        public int? AcesModoAquisId { get; set; }
        public int? AcesRecursoFinId { get; set; }
        public string? AcesNumNotaFiscal { get; set; }
        public DateTime? AcesDataAquis { get; set; }
        public DateTime? AcesDtGarantia { get; set; }
        public string? AcesSerie { get; set; }
        public int? AcesQtde { get; set; }
        public decimal? AcesVlrTotal { get; set; }
        public string? AcesDescricao { get; set; }
        public long? ItemId { get; set; }
        public string? AcesCnpjmembro { get; set; }
        public int? AcesQtdeDisp { get; set; }

        public virtual Contribuinte? AcesFornecedor { get; set; }
        public virtual MoveisIten? Item { get; set; }

        public virtual ICollection<MoveisEquipamento> MoeMovEquips { get; set; }
    }
}
