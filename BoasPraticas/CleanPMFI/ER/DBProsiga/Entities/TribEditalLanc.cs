using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEditalLanc
{
    public int EdiId { get; set; }

    public int? EdiNumero { get; set; }

    public short? EdiAno { get; set; }

    public DateTime? EdiData { get; set; }

    public long? TextoId { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? Host { get; set; }

    public virtual ICollection<TribCmoficio> TribCmoficios { get; set; } = new List<TribCmoficio>();

    public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; } = new List<TribCmprocesso>();

    public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; } = new List<TribEditalLancDivida>();

    public virtual ICollection<TribEditalLancVenc> TribEditalLancVencs { get; set; } = new List<TribEditalLancVenc>();

    public virtual ICollection<TribEmpresasTiposAlvara> TribEmpresasTiposAlvaras { get; set; } = new List<TribEmpresasTiposAlvara>();

    public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; } = new List<TribOrigemDividum>();
}
