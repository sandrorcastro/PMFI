using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsInterveniente
    {
        public int IdIntervenientes { get; set; }
        public short IdEmpresa { get; set; }
        public int IdSubvencaoSocial { get; set; }
        public int IdPessoa { get; set; }
        public string CdResponsabilidade { get; set; } = null!;
        public string? CdTipoParticipacao { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }

        public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;
        public virtual TbSbsSubvencaoSocial IdSubvencaoSocialNavigation { get; set; } = null!;
    }
}
