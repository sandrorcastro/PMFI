using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcAlteracoesOrcamentaria
    {
        public TbOrcAlteracoesOrcamentaria()
        {
            IdSolicitacaoDotacaos = new HashSet<TbOrcSolicitacoesSuplementacaoDotaco>();
        }

        public int IdAlteracao { get; set; }
        public short? IdEmpresa { get; set; }
        public int IdAtoAlteracao { get; set; }
        public short IdTipoAlteracao { get; set; }
        public int? Iddotacao { get; set; }
        public short IdTipoRecurso { get; set; }
        public int? IdLimiteCredito { get; set; }
        public string? DsTipoCredito { get; set; }
        public string? DsObservacao { get; set; }
        public decimal? VlAlteracao { get; set; }
        public int? IdTcepessoaTransf { get; set; }
        public short? IdEmpresaTransf { get; set; }
        public int? IdSolicitacao { get; set; }
        public int? IdSubAcaoTarefa { get; set; }
        public short? IdTipoCreditoAdicional { get; set; }
        public short? IdTipoOperacaoCreditoAdicional { get; set; }
        public string? FlTipoTransferencia { get; set; }

        public virtual TbOrcAtosAlteraco IdAtoAlteracaoNavigation { get; set; } = null!;
        public virtual TbOrcLimitesCreditoAdicional? IdLimiteCreditoNavigation { get; set; }
        public virtual TbOrcTiposAlteracaoOrcamentarium IdTipoAlteracaoNavigation { get; set; } = null!;
        public virtual TbOrcTipoCreditoAdicional? IdTipoCreditoAdicionalNavigation { get; set; }
        public virtual TbOrcTiposOperacaoCreditoAdicional? IdTipoOperacaoCreditoAdicionalNavigation { get; set; }
        public virtual TbOrcTiposRecurso IdTipoRecursoNavigation { get; set; } = null!;
        public virtual TbOrcDotaco? IddotacaoNavigation { get; set; }

        public virtual ICollection<TbOrcSolicitacoesSuplementacaoDotaco> IdSolicitacaoDotacaos { get; set; }
    }
}
