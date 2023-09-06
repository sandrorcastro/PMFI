using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbDaprevium
    {
        public int IdPrevia { get; set; }
        public int? IdInscricao { get; set; }
        public string? NrInscricao { get; set; }
        public int? IdDivida { get; set; }
        public string? TipoTribNome { get; set; }
        public int? TipoTribId { get; set; }
        public decimal? VlDivida { get; set; }
        public DateTime? Vencimento { get; set; }
        public string? CodDivida { get; set; }
        public string? TpCadastro { get; set; }
        public string? DsErro { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtProcessamento { get; set; }
        public bool? FlInscreverDa { get; set; }
        public bool? FlProcessado { get; set; }
        public int? NrAno { get; set; }
    }
}
