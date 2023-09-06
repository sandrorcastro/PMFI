using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmptbOrcNaturezasDespesa
    {
        public int IdNatDespesa { get; set; }
        public short? IdEmpresa { get; set; }
        public short NrAno { get; set; }
        public string? CdNatDespesa { get; set; }
        public string? DsNatDespesa { get; set; }
        public string? DsEspecificacao { get; set; }
        public string? FlNatDespesaPadrao { get; set; }
        public string? DsTipoNatDespesaPadrao { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtDesativacao { get; set; }
        public int? IdNatDespesaNivelSuper { get; set; }
    }
}
