using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Publicacao
{
    public int IdPublicacao { get; set; }

    public DateTime DthAgendamento { get; set; }

    public string StaMotivo { get; set; } = null!;

    public DateTime DtaDisponibilizacao { get; set; }

    public DateTime? DtaPublicacaoIo { get; set; }

    public string? PaginaIo { get; set; }

    public string? Resumo { get; set; }

    public DateTime? DtaPublicacao { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public long? IdDocumento { get; set; }

    public int IdAtividade { get; set; }

    public int? Numero { get; set; }

    public int IdVeiculoPublicacao { get; set; }

    public int? IdVeiculoIo { get; set; }

    public int? IdSecaoIo { get; set; }

    public virtual Atividade IdAtividadeNavigation { get; set; } = null!;

    public virtual Documento? IdDocumentoNavigation { get; set; }

    public virtual SecaoImprensaNacional? IdSecaoIoNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual VeiculoImprensaNacional? IdVeiculoIoNavigation { get; set; }

    public virtual VeiculoPublicacao IdVeiculoPublicacaoNavigation { get; set; } = null!;
}
