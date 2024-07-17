using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class BaseConhecimento
{
    public int IdBaseConhecimento { get; set; }

    public int? IdBaseConhecimentoAgrupador { get; set; }

    public int? IdBaseConhecimentoOrigem { get; set; }

    public int IdUnidade { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Conteudo { get; set; }

    public long? IdDocumentoEdoc { get; set; }

    public string StaEstado { get; set; } = null!;

    public int IdUsuarioGerador { get; set; }

    public DateTime DthGeracao { get; set; }

    public DateTime? DthLiberacao { get; set; }

    public int? IdUsuarioLiberacao { get; set; }

    public int? IdConjuntoEstilos { get; set; }

    public string StaDocumento { get; set; } = null!;

    public virtual ICollection<Anexo> Anexos { get; set; } = new List<Anexo>();

    public virtual ConjuntoEstilo? IdConjuntoEstilosNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioGeradorNavigation { get; set; } = null!;

    public virtual Usuario? IdUsuarioLiberacaoNavigation { get; set; }

    public virtual ICollection<SecaoDocumento> SecaoDocumentos { get; set; } = new List<SecaoDocumento>();

    public virtual ICollection<TipoProcedimento> IdTipoProcedimentos { get; set; } = new List<TipoProcedimento>();
}
