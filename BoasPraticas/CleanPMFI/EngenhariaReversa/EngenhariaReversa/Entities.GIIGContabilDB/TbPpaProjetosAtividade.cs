using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaProjetosAtividade
    {
        public TbPpaProjetosAtividade()
        {
            TbPpaProgramasAcos = new HashSet<TbPpaProgramasAco>();
        }

        public int IdProjetoAtividade { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrVersao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string CdFuncao { get; set; } = null!;
        public string CdSubFuncao { get; set; } = null!;
        public string? CdPrograma { get; set; }
        public string? CdProjetoAtividade { get; set; }
        public string? DsProjetoAtividade { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbPpaProgramasAco> TbPpaProgramasAcos { get; set; }
    }
}
