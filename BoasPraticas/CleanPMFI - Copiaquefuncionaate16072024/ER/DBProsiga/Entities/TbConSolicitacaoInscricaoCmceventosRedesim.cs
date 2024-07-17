using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbConSolicitacaoInscricaoCmceventosRedesim
{
    public int Idevento { get; set; }

    public int? Idsolicitacaoinscricao { get; set; }

    public int? Evento { get; set; }

    /// <summary>
    /// Data de gravação do registro.
    /// </summary>
    public DateTime Dtinclusao { get; set; }
}
