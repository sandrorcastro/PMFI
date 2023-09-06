using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcAtosAlteraco
    {
        public TbOrcAtosAlteraco()
        {
            TbOrcAlteracoesOrcamentaria = new HashSet<TbOrcAlteracoesOrcamentaria>();
        }

        public int IdAtoAlteracao { get; set; }
        public short? IdEmpresa { get; set; }
        public short IdTipoAtoAlteracao { get; set; }
        public string? DsMensagem { get; set; }
        public int? NrAtoAlteracao { get; set; }
        public short? NrAnoAtoAlteracao { get; set; }
        public DateTime? DtAtoAlteracao { get; set; }
        public DateTime? DtPublicacao { get; set; }
        public int? IdAto { get; set; }
        public int? NrLei { get; set; }
        public short? NrAnoLei { get; set; }
        public DateTime? DtLei { get; set; }
        public DateTime? DtPublicacaoLei { get; set; }
        public int? IdLei { get; set; }
        public string? DsSituacao { get; set; }
        public string? DsObservacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdLimiteCredito { get; set; }
        public int? NrOrgaoOficial { get; set; }
        public string? NrPaginas { get; set; }
        public int? IdLeiOrcamentaria { get; set; }
        public DateTime? DtDeferimento { get; set; }
        public DateTime? DtPublicacaoBelem { get; set; }
        public short? TpPortaria { get; set; }

        public virtual TbOrcTiposAtoAlteracao IdTipoAtoAlteracaoNavigation { get; set; } = null!;
        public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; }
    }
}
