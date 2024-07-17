using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Assinatura
{
    public int IdAssinatura { get; set; }

    public long IdDocumento { get; set; }

    public int IdUsuario { get; set; }

    public int IdUnidade { get; set; }

    public string Nome { get; set; } = null!;

    public string Tratamento { get; set; } = null!;

    public long? Cpf { get; set; }

    public int? IdAtividade { get; set; }

    public string StaFormaAutenticacao { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public string? NumeroSerieCertificado { get; set; }

    public string? P7sBase64 { get; set; }

    public int IdTarjaAssinatura { get; set; }

    public string? Agrupador { get; set; }

    public virtual Atividade? IdAtividadeNavigation { get; set; }

    public virtual Documento IdDocumentoNavigation { get; set; } = null!;

    public virtual TarjaAssinatura IdTarjaAssinaturaNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
