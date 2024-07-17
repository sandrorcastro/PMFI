using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AguaEdificacoesHidrometro
{
    public int EdifHidroId { get; set; }

    public long? EdificacaoId { get; set; }

    public int? HidroId { get; set; }

    public string? EdifHidroEndHidrometro { get; set; }

    public DateTime? EdifHidroDataInicio { get; set; }

    public DateTime? EdifHidroDataFinal { get; set; }

    public string? EdifHidroHistorico { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual AguaHidrometro? Hidro { get; set; }
}
