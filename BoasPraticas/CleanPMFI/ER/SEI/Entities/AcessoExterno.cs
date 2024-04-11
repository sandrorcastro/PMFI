using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AcessoExterno
{
    public int IdAcessoExterno { get; set; }

    public int IdAtividade { get; set; }

    public int IdParticipante { get; set; }

    public DateTime? DtaValidade { get; set; }

    public string? EmailUnidade { get; set; }

    public string HashInterno { get; set; } = null!;

    public string StaTipo { get; set; } = null!;

    public long? IdDocumento { get; set; }

    public string SinProcesso { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public string? EmailDestinatario { get; set; }

    public string SinInclusao { get; set; } = null!;

    public DateTime? DthVisualizacao { get; set; }

    public virtual Atividade IdAtividadeNavigation { get; set; } = null!;

    public virtual Documento? IdDocumentoNavigation { get; set; }

    public virtual Participante IdParticipanteNavigation { get; set; } = null!;

    public virtual ICollection<Protocolo> IdProtocolos { get; set; } = new List<Protocolo>();

    public virtual ICollection<Serie> IdSeries { get; set; } = new List<Serie>();
}
