using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsLegislacaoEspecificaConcedente
{
    public int IdLegislacaoEspecifica { get; set; }

    public int? IdSubVencaoSocial { get; set; }

    public string? CdtipoAtoLegislacaoEspecifica { get; set; }

    public string? NrAtoLegislacaoEspecifica { get; set; }

    public short? NrAno { get; set; }

    public string? CdAssuntoLegislacaoEspecifica { get; set; }

    public virtual TbSbsSubvencaoSocial? IdSubVencaoSocialNavigation { get; set; }
}
