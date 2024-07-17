using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class ProdRurNotaFiscalIten
    {
        public int IdnotaFiscal { get; set; }
        public int IdprodRural { get; set; }
        public int? UnMedId { get; set; }
        public int? Idimposto { get; set; }
        public decimal? Qtde { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? Aliquota { get; set; }

        public virtual ProdRurImposto? IdimpostoNavigation { get; set; }
        public virtual ProdRurNotaFiscal IdnotaFiscalNavigation { get; set; } = null!;
        public virtual ProdRurProdutosRurai IdprodRuralNavigation { get; set; } = null!;
        public virtual AlmUnMed? UnMed { get; set; }
    }
}
