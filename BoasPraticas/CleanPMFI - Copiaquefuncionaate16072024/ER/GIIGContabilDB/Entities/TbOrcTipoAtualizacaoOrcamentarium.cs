using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcTipoAtualizacaoOrcamentarium
{
    public short IdTipoAtualizacaoOrcamentaria { get; set; }

    public string? DsTipoAtualizacaoOrcamentaria { get; set; }

    public string? TpGrupo { get; set; }

    public virtual ICollection<TbOrcAtualizacoesMonetariaOrcamento> TbOrcAtualizacoesMonetariaOrcamentos { get; set; } = new List<TbOrcAtualizacoesMonetariaOrcamento>();

    public virtual ICollection<TbOrcReceitasReestimada> TbOrcReceitasReestimada { get; set; } = new List<TbOrcReceitasReestimada>();
}
