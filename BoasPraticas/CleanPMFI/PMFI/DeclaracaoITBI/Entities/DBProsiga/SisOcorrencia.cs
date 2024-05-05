using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SisOcorrencia
{
    public int Idocorrencia { get; set; }

    public string TipoOcorrencia { get; set; } = null!;

    public string? FrmId { get; set; }

    public string? UsuId { get; set; }

    public string DescricaoOcorrencia { get; set; } = null!;

    public DateTime? DataOcorrencia { get; set; }

    public virtual Usuario? Usu { get; set; }
}
