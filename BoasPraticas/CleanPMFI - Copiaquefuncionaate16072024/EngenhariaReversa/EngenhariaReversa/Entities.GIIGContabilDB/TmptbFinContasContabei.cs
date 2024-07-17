using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmptbFinContasContabei
    {
        public int IdContaContabil { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdContaContabil { get; set; }
        public string? DsContaContabil { get; set; }
        public string? DsEspecificacao { get; set; }
        public decimal? VlSaldoInicial { get; set; }
        public string? FlContaPadrao { get; set; }
        public string? DsTipoContaPadrao { get; set; }
        public string? DsCategoriaConta { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtDesativacao { get; set; }
        public int? IdContaContabilNivelSuperior { get; set; }
        public DateTime? DtCriacao { get; set; }
        public string? DsLoginInclusao { get; set; }
        public string? DsLoginAlteracao { get; set; }
        public string? TpNaturezaSaldo { get; set; }
        public string? FlEscrituracao { get; set; }
        public string? TpNaturezaInformacao { get; set; }
        public string? TpIndicSupFinanc { get; set; }
        public string? TpControle { get; set; }
    }
}
