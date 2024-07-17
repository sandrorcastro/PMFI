using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribProcArrestoPenhora
{
    public long ProcArrId { get; set; }

    public long? ProcId { get; set; }

    public string? ProcArrTipo { get; set; }

    public DateTime? DataInclusao { get; set; }

    public DateTime? DataAlteracao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? UsuarioAlteracao { get; set; }

    public virtual TribProcProcesso? Proc { get; set; }

    public virtual ICollection<TribProcArrestoPenhoraDetalhe> TribProcArrestoPenhoraDetalhes { get; set; } = new List<TribProcArrestoPenhoraDetalhe>();

    public virtual ICollection<TribProcArrestoPenhoraExecutado> TribProcArrestoPenhoraExecutados { get; set; } = new List<TribProcArrestoPenhoraExecutado>();

    public virtual ICollection<TribProcArrestoPenhoraIntimacao> TribProcArrestoPenhoraIntimacaos { get; set; } = new List<TribProcArrestoPenhoraIntimacao>();
}
