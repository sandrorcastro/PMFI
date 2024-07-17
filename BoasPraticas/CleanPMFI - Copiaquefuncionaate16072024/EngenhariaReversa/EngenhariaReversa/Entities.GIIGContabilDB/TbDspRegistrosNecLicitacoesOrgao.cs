using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspRegistrosNecLicitacoesOrgao
    {
        public TbDspRegistrosNecLicitacoesOrgao()
        {
            TbDspRegistrosNecLicitOrgaosItens = new HashSet<TbDspRegistrosNecLicitOrgaosIten>();
        }

        public int IdRegistroOrgao { get; set; }
        public int IdRegistro { get; set; }
        public short IdEmpresa { get; set; }
        public short NrAno { get; set; }
        public string? DsRegistroOrgao { get; set; }
        public string CdOrgao { get; set; } = null!;
        public string? CdUnidade { get; set; }
        public bool? FlCriadoOrgao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? DsJustificativa { get; set; }

        public virtual TbDspRegistrosNecessidadeLicitaco IdRegistroNavigation { get; set; } = null!;
        public virtual TbOrcOrgao TbOrcOrgao { get; set; } = null!;
        public virtual ICollection<TbDspRegistrosNecLicitOrgaosIten> TbDspRegistrosNecLicitOrgaosItens { get; set; }
    }
}
