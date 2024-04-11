using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspRegistrosNecessidadeLicitaco
{
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

    public virtual ICollection<TbDspRegistrosNecLicitacoesAnexo> TbDspRegistrosNecLicitacoesAnexos { get; set; } = new List<TbDspRegistrosNecLicitacoesAnexo>();

    public virtual ICollection<TbDspRegistrosNecLicitacoesDotaco> TbDspRegistrosNecLicitacoesDotacos { get; set; } = new List<TbDspRegistrosNecLicitacoesDotaco>();

    public virtual ICollection<TbDspRegistrosNecLicitacoesIten> TbDspRegistrosNecLicitacoesItens { get; set; } = new List<TbDspRegistrosNecLicitacoesIten>();

    public virtual ICollection<TbDspRegistrosNecLicitacoesOrgao> TbDspRegistrosNecLicitacoesOrgaos { get; set; } = new List<TbDspRegistrosNecLicitacoesOrgao>();
}
