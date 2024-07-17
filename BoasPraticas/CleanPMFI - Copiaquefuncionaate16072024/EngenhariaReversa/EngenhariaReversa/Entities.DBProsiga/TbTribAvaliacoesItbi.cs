using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbTribAvaliacoesItbi
    {
        public int IdAvaliacao { get; set; }
        public int NrAvaliacao { get; set; }
        public int NrAno { get; set; }
        public int EdificacaoId { get; set; }
        public int? IdRequerente { get; set; }
        public bool FlFinanciado { get; set; }
        public decimal? VlDeclarado { get; set; }
        public decimal? VlBaseCalculo { get; set; }
        public decimal? VlAliquota { get; set; }
        public decimal? VlBaseCalculoFinanciado { get; set; }
        public decimal? VlAliquotaFinanciado { get; set; }
        public decimal? VlParteIdeal { get; set; }
        public DateTime? DtValidade { get; set; }
        public string? DsObservacao { get; set; }
        public bool? FlSomarEconomias { get; set; }
        public string? DsTipoConstrucao { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsMatricula { get; set; }
    }
}
