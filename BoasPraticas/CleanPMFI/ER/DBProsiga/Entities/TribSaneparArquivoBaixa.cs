using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSaneparArquivoBaixa
{
    public int SaneArqId { get; set; }

    public string? SaneArqNome { get; set; }

    public short? SaneArqMes { get; set; }

    public short? SaneArqAno { get; set; }

    public DateTime? SaneArqDataInclusao { get; set; }

    public string? SaneArqUsuario { get; set; }

    public virtual ICollection<TribSaneparArquivoBaixaDetalhe> TribSaneparArquivoBaixaDetalhes { get; set; } = new List<TribSaneparArquivoBaixaDetalhe>();
}
