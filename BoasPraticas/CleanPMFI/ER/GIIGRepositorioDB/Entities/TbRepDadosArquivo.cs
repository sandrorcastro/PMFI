using System;
using System.Collections.Generic;

namespace GIIGRepositorioDB.Entities;

public partial class TbRepDadosArquivo
{
    public long IdReferencia { get; set; }

    public int? IdRepositorio { get; set; }

    public string? NrReferencia { get; set; }

    public long? IdArquivo { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? NmUsuario { get; set; }

    public string? DsPalavraChave { get; set; }

    public string? FlExcluido { get; set; }

    public string? DsExclusao { get; set; }

    public virtual TbRepRepositorio? IdRepositorioNavigation { get; set; }
}
