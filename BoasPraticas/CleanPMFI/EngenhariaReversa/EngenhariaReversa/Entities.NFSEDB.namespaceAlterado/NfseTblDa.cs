using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblDa
    {
        public int Iddas { get; set; }
        public string Nunumerodoc { get; set; } = null!;
        public DateTime Dtlimiteacolh { get; set; }
        public DateTime Dtcompetencia { get; set; }
        public DateTime Dtvencimento { get; set; }
        public decimal Vlprincipal { get; set; }
        public decimal Vlmulta { get; set; }
        public decimal Vljuroencargo { get; set; }
        public decimal Vltotal { get; set; }
        public DateTime? Dtpagamento { get; set; }
        public decimal? Vlreceitabruta { get; set; }
        public decimal? Pcaliquota { get; set; }
        public string Stsituacao { get; set; } = null!;
        public DateTime Dtdeclaracao { get; set; }
        public int? Idempresa { get; set; }
        public int? Numes { get; set; }
        public int? Nuano { get; set; }
        public string? Stcnpjresponsavel { get; set; }
        public decimal? Vlbasecalculo { get; set; }
        public string? Stdescricao { get; set; }
    }
}
