using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsAditivo
    {
        public TbSbsAditivo()
        {
            TbSbsCronogramaDesembolsoAditivos = new HashSet<TbSbsCronogramaDesembolsoAditivo>();
        }

        public int IdAditivo { get; set; }
        public short IdEmpresa { get; set; }
        public int IdSubvencaoSocial { get; set; }
        public long NrAditivo { get; set; }
        public DateTime DtAditivo { get; set; }
        public string FlPrazo { get; set; } = null!;
        public DateTime? DtVencimentoConvenio { get; set; }
        public string FlValor { get; set; } = null!;
        public decimal? VlRepasse { get; set; }
        public decimal? VlContrapartida { get; set; }
        public int? IdDotacao { get; set; }
        public string FlObjeto { get; set; } = null!;
        public string DsAditivoObjeto { get; set; } = null!;
        public string FlCronograma { get; set; } = null!;
        public short IdVeiculoPublicacao { get; set; }
        public DateTime DtPublicacao { get; set; }
        public long NrEdicaoPublicacao { get; set; }
        public string FlPlanoAplicacao { get; set; } = null!;
        public DateTime? DtAssinatura { get; set; }
        public DateTime? DtFimVigencia { get; set; }
        public DateTime? DtFimExecucao { get; set; }
        public string? CdModalidadeAplicacao { get; set; }
        public int? IdPessoaFiscalizador { get; set; }
        public string? CdTipoAditivo { get; set; }
        public string? FlFiscalGestor { get; set; }

        public virtual TbGerPessoa? IdPessoaFiscalizadorNavigation { get; set; }
        public virtual TbSbsSubvencaoSocial IdSubvencaoSocialNavigation { get; set; } = null!;
        public virtual TbLicVeiculosPublicaco IdVeiculoPublicacaoNavigation { get; set; } = null!;
        public virtual ICollection<TbSbsCronogramaDesembolsoAditivo> TbSbsCronogramaDesembolsoAditivos { get; set; }
    }
}
