using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Rhlicenca
{
    public long AcoLicId { get; set; }

    public DateTime? AcoLicData { get; set; }

    public DateTime? AcoLicDataIni { get; set; }

    public DateTime? AcoLicDataFim { get; set; }

    public long? TipoLicId { get; set; }

    public long? DadFid { get; set; }

    public virtual RhdadosFuncionai? DadF { get; set; }

    public virtual RhtipoLicenca? TipoLic { get; set; }
}
