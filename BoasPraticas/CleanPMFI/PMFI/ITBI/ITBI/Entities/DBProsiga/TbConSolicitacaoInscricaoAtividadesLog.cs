using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TbConSolicitacaoInscricaoAtividadesLog
{
    public int? IdSolicitacaoInscricaoAtividade { get; set; }

    public long IdSolicitacaoInscricao { get; set; }

    public string Atividade { get; set; } = null!;

    public bool? FlPrincipal { get; set; }

    public DateTime? DtInicial { get; set; }

    public string? DsOperacao { get; set; }
}
