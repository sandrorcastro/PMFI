using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class SecaoDocumento
{
    public int IdSecaoDocumento { get; set; }

    public int IdSecaoModelo { get; set; }

    public long? IdDocumento { get; set; }

    public int? IdBaseConhecimento { get; set; }

    public int Ordem { get; set; }

    public string SinSomenteLeitura { get; set; } = null!;

    public string SinAssinatura { get; set; } = null!;

    public string SinPrincipal { get; set; } = null!;

    public string SinDinamica { get; set; } = null!;

    public string SinCabecalho { get; set; } = null!;

    public string SinRodape { get; set; } = null!;

    public string? Conteudo { get; set; }

    public string SinHtml { get; set; } = null!;

    public virtual BaseConhecimento? IdBaseConhecimentoNavigation { get; set; }

    public virtual Documento? IdDocumentoNavigation { get; set; }

    public virtual SecaoModelo IdSecaoModeloNavigation { get; set; } = null!;

    public virtual ICollection<VersaoSecaoDocumento> VersaoSecaoDocumentos { get; set; } = new List<VersaoSecaoDocumento>();
}
