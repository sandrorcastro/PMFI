using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsPlanoTrabalho
    {
        public int IdPlanoTrabalho { get; set; }
        public int? IdSubVencaoSocial { get; set; }
        public string? CdObjetosPlanoTrabalho { get; set; }
        public string? DsMeta { get; set; }
        public string? NrArt { get; set; }
        public string? NrCrea { get; set; }
        public int? IdProfissionalResponsavel { get; set; }
        public string? NrMatriculaImovel { get; set; }
        public DateTime? DtValidadeCertidaoRegImovel { get; set; }
        public string? NmCartorioRegistroImovel { get; set; }
        public DateTime? DtEmissaoCertidaoRegImovel { get; set; }
        public string? CdUnidadeMedida { get; set; }
        public string? QtUnidadeMedida { get; set; }

        public virtual TbGerPessoa? IdProfissionalResponsavelNavigation { get; set; }
        public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
    }
}
