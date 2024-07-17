using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AtoBaixa
    {
        public AtoBaixa()
        {
            BaixaImoveisImobens = new HashSet<BaixaImoveisImoben>();
            BaixaMoveisEquipamentos = new HashSet<BaixaMoveisEquipamento>();
            VeiculosBaixados = new HashSet<VeiculosBaixado>();
        }

        public int AtoId { get; set; }
        public string? AtoNumero { get; set; }
        public int? AtoAno { get; set; }
        public string? AtoTipo { get; set; }
        public DateTime? AtoData { get; set; }
        public int? AtoTipoBaixaId { get; set; }

        public virtual TipoBaixa? AtoTipoBaixa { get; set; }
        public virtual ICollection<BaixaImoveisImoben> BaixaImoveisImobens { get; set; }
        public virtual ICollection<BaixaMoveisEquipamento> BaixaMoveisEquipamentos { get; set; }
        public virtual ICollection<VeiculosBaixado> VeiculosBaixados { get; set; }
    }
}
