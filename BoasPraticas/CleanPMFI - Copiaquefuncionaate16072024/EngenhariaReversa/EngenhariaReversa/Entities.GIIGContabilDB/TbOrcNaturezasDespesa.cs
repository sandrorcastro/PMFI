using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcNaturezasDespesa
    {
        public TbOrcNaturezasDespesa()
        {
            InverseIdNatDespesaNivelSuperNavigation = new HashSet<TbOrcNaturezasDespesa>();
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbOrcDotacos = new HashSet<TbOrcDotaco>();
            TbOrcSolicitacoesSaldoDotacaos = new HashSet<TbOrcSolicitacoesSaldoDotacao>();
            TbSbsCronogramaDesembolsoAditivos = new HashSet<TbSbsCronogramaDesembolsoAditivo>();
            TbSbsPlanoAplicacoesAditivos = new HashSet<TbSbsPlanoAplicacoesAditivo>();
        }

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

        public virtual TbOrcNaturezasDespesa? IdNatDespesaNivelSuperNavigation { get; set; }
        public virtual ICollection<TbOrcNaturezasDespesa> InverseIdNatDespesaNivelSuperNavigation { get; set; }
        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbOrcDotaco> TbOrcDotacos { get; set; }
        public virtual ICollection<TbOrcSolicitacoesSaldoDotacao> TbOrcSolicitacoesSaldoDotacaos { get; set; }
        public virtual ICollection<TbSbsCronogramaDesembolsoAditivo> TbSbsCronogramaDesembolsoAditivos { get; set; }
        public virtual ICollection<TbSbsPlanoAplicacoesAditivo> TbSbsPlanoAplicacoesAditivos { get; set; }
    }
}
