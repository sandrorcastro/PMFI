using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspRegistrosNecessidadeLicitaco
    {
        public TbDspRegistrosNecessidadeLicitaco()
        {
            TbDspRegistrosNecLicitacoesAnexos = new HashSet<TbDspRegistrosNecLicitacoesAnexo>();
            TbDspRegistrosNecLicitacoesDotacos = new HashSet<TbDspRegistrosNecLicitacoesDotaco>();
            TbDspRegistrosNecLicitacoesItens = new HashSet<TbDspRegistrosNecLicitacoesIten>();
            TbDspRegistrosNecLicitacoesOrgaos = new HashSet<TbDspRegistrosNecLicitacoesOrgao>();
        }

        public int IdRegistro { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtRegistro { get; set; }
        public string? DsRegistro { get; set; }
        public string? DsOrientacoes { get; set; }
        public DateTime? DtLimiteSolicitacoes { get; set; }
        public string? DsOrigemSaldo { get; set; }
        public bool? FlPermiteAddItens { get; set; }
        public string? DsLogin { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }

        public virtual ICollection<TbDspRegistrosNecLicitacoesAnexo> TbDspRegistrosNecLicitacoesAnexos { get; set; }
        public virtual ICollection<TbDspRegistrosNecLicitacoesDotaco> TbDspRegistrosNecLicitacoesDotacos { get; set; }
        public virtual ICollection<TbDspRegistrosNecLicitacoesIten> TbDspRegistrosNecLicitacoesItens { get; set; }
        public virtual ICollection<TbDspRegistrosNecLicitacoesOrgao> TbDspRegistrosNecLicitacoesOrgaos { get; set; }
    }
}
