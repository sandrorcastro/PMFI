using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspSolicitacoesEmpenho
    {
        public TbDspSolicitacoesEmpenho()
        {
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbDspSolicitacoesEmpenhoCancelada = new HashSet<TbDspSolicitacoesEmpenhoCancelada>();
            TbDspSolicitacoesEmpenhoItens = new HashSet<TbDspSolicitacoesEmpenhoIten>();
        }

        public int IdSolicitacaoEmpenho { get; set; }
        public int IdRms { get; set; }
        public short? NrSequencia { get; set; }
        public int? IdPessoa { get; set; }
        public short IdCondicaoPgto { get; set; }
        public short IdPrazoEntrega { get; set; }
        public DateTime? DtSolicitacaoEmpenho { get; set; }
        public DateTime? DtVencimentoProposta { get; set; }
        public decimal? VlSolicitacaoEmpenho { get; set; }
        public int? IdLicitacao { get; set; }
        public int? IdContrato { get; set; }
        public short? NrMesCompetencia { get; set; }
        public short? NrAnoCompetencia { get; set; }
        public short? NrParcelas { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? IdSolicitacaoParcelada { get; set; }
        public string? DsObservacao { get; set; }
        public string? FlContraPartida { get; set; }
        public int? IdRecurso { get; set; }
        public string? NrProcesso { get; set; }
        public short? NrAnoProcesso { get; set; }
        public int? IdNumeroAto { get; set; }

        public virtual TbGerCondicoesPagamento IdCondicaoPgtoNavigation { get; set; } = null!;
        public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
        public virtual TbGerPrazosEntrega IdPrazoEntregaNavigation { get; set; } = null!;
        public virtual TbDspRm IdRmsNavigation { get; set; } = null!;
        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbDspSolicitacoesEmpenhoCancelada> TbDspSolicitacoesEmpenhoCancelada { get; set; }
        public virtual ICollection<TbDspSolicitacoesEmpenhoIten> TbDspSolicitacoesEmpenhoItens { get; set; }
    }
}
