using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcOrgao
    {
        public TbOrcOrgao()
        {
            TbDspRegistrosNecLicitacoesOrgaos = new HashSet<TbDspRegistrosNecLicitacoesOrgao>();
            TbGerCargosServidores = new HashSet<TbGerCargosServidore>();
            TbOrcUnidades = new HashSet<TbOrcUnidade>();
        }

        public short Idempresa { get; set; }
        public short NrAno { get; set; }
        public string CdOrgao { get; set; } = null!;
        public string? NmOrgao { get; set; }
        public string? DsTipoOrgao { get; set; }
        public DateTime? DtExtincao { get; set; }
        public string? DsSiglaAcoes { get; set; }
        public short? IdempresaExecutora { get; set; }
        public string? CdReferenciaTce { get; set; }
        public string? CdTipoOrgao { get; set; }
        public string? CdlOrgaoOriginal { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TbGerEmpresasGoverno IdempresaNavigation { get; set; } = null!;
        public virtual ICollection<TbDspRegistrosNecLicitacoesOrgao> TbDspRegistrosNecLicitacoesOrgaos { get; set; }
        public virtual ICollection<TbGerCargosServidore> TbGerCargosServidores { get; set; }
        public virtual ICollection<TbOrcUnidade> TbOrcUnidades { get; set; }
    }
}
