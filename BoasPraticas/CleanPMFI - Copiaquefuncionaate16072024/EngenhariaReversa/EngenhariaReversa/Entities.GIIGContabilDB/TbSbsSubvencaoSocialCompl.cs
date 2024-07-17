using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsSubvencaoSocialCompl
    {
        public TbSbsSubvencaoSocialCompl()
        {
            Cds = new HashSet<TbSbsComplementosSit>();
        }

        public int IdSubVencaoSocial { get; set; }
        public int? IdPessoaFiscalizador { get; set; }
        public string? DsCargoPessoaFiscalizador { get; set; }
        public int? IdContaCorrente { get; set; }
        public string? NrProcedimento { get; set; }
        public short? NrAnoProcedimento { get; set; }
        public DateTime? DtPublicacaoProcedimento { get; set; }
        public string? NrAtaConselho { get; set; }
        public DateTime? DtAtaConselho { get; set; }
        public string? DsPeriodicoOficalCedente { get; set; }
        public string? DsPeriodicoOficalTomador { get; set; }

        public virtual TbGerContasCorrente? IdContaCorrenteNavigation { get; set; }
        public virtual TbGerPessoa? IdPessoaFiscalizadorNavigation { get; set; }
        public virtual TbSbsSubvencaoSocial IdSubVencaoSocialNavigation { get; set; } = null!;

        public virtual ICollection<TbSbsComplementosSit> Cds { get; set; }
    }
}
