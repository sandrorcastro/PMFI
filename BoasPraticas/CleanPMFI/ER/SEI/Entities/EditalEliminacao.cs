using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class EditalEliminacao
{
    public int IdEditalEliminacao { get; set; }

    public long? IdProcedimento { get; set; }

    public long? IdDocumento { get; set; }

    public int IdUnidade { get; set; }

    public string Especificacao { get; set; } = null!;

    public DateTime? DtaPublicacao { get; set; }

    public string StaEditalEliminacao { get; set; } = null!;

    public virtual ICollection<EditalEliminacaoConteudo> EditalEliminacaoConteudos { get; set; } = new List<EditalEliminacaoConteudo>();

    public virtual Documento? IdDocumentoNavigation { get; set; }

    public virtual Procedimento? IdProcedimentoNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
