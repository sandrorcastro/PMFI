using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLicitacoesAbertura
{
    public int IdLicitacaoAbertura { get; set; }

    public int IdLicitacao { get; set; }

    public short NrExercicio { get; set; }

    public short? NrMes { get; set; }
}
