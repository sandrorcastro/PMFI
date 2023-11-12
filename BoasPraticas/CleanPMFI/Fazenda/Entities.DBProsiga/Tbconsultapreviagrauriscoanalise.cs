using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbconsultapreviagrauriscoanalise
{
    public int Idanalisegraurisco { get; set; }

    public int Idconsulta { get; set; }

    public string Atividade { get; set; } = null!;

    public short SetorId { get; set; }

    public int Idrisco { get; set; }

    /// <summary>
    /// Aceito, Em Exigencia, Negado
    /// </summary>
    public string Flparecer { get; set; } = null!;

    public DateTime? Dtparecer { get; set; }

    public string? Dsparecer { get; set; }

    public int? Idusuarioparecer { get; set; }
}
