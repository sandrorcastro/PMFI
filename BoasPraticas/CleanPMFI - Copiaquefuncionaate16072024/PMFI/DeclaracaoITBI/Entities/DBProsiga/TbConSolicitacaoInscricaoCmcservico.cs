using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TbConSolicitacaoInscricaoCmcservico
{
    public long IdSolicitacaoInscricaoServico { get; set; }

    public long? IdSolicitacaoInscricao { get; set; }

    public string? ServId { get; set; }

    public string? DsDescricao { get; set; }

    public DateTime? DtInicial { get; set; }

    public DateTime? DtFinal { get; set; }

    public string? DsMotivo { get; set; }

    public string? DsIncidencia { get; set; }

    public bool? FlPrincipal { get; set; }
}
