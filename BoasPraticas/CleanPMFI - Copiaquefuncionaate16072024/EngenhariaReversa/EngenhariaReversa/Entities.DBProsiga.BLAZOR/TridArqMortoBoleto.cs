using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TridArqMortoBoleto
    {
        public int Id { get; set; }
        public string? NossoNumero { get; set; }
        public string? EdificacaoId { get; set; }
        public int? Cmc { get; set; }
        public long? ConId { get; set; }
        public string? Cgccpf { get; set; }
        public int? ImoIddivida { get; set; }
        public int? ConIddivida { get; set; }
        public int? EmpIddivida { get; set; }
        public short? AnoDivida { get; set; }
        public short? MesDivida { get; set; }
        public int? TipoTribId { get; set; }
        public int? SubDivida { get; set; }
        public int? Parcela { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataBoleto { get; set; }
        public decimal? BoleValorPrinc { get; set; }
        public decimal? BoleValorDesconto { get; set; }
        public decimal? BoleValorJuros { get; set; }
        public decimal? BoleValorMulta { get; set; }
        public decimal? BoleValorCorrecao { get; set; }
        public string? BoleIp { get; set; }
        public string? BoleOrigem { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
    }
}
