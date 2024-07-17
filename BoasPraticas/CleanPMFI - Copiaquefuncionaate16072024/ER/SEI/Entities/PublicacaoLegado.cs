using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class PublicacaoLegado
{
    public int IdPublicacaoLegado { get; set; }

    public int IdPublicacaoLegadoAgrupador { get; set; }

    public string IdDocumento { get; set; } = null!;

    public int IdSerie { get; set; }

    public int IdUnidade { get; set; }

    public DateTime? DtaPublicacaoIo { get; set; }

    public string? PaginaIo { get; set; }

    public DateTime DtaPublicacao { get; set; }

    public string? Numero { get; set; }

    public string? Resumo { get; set; }

    public string ConteudoDocumento { get; set; } = null!;

    public DateTime DtaGeracao { get; set; }

    public int IdOrgao { get; set; }

    public string ProtocoloFormatado { get; set; } = null!;

    public int? IdSecaoIo { get; set; }

    public int? IdVeiculoIo { get; set; }

    public int IdVeiculoPublicacao { get; set; }

    public virtual SecaoImprensaNacional? IdSecaoIoNavigation { get; set; }

    public virtual Serie IdSerieNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual VeiculoImprensaNacional? IdVeiculoIoNavigation { get; set; }

    public virtual VeiculoPublicacao IdVeiculoPublicacaoNavigation { get; set; } = null!;
}
