using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class OperacaoServico
{
    public int IdOperacaoServico { get; set; }

    public int StaOperacaoServico { get; set; }

    public int? IdTipoProcedimento { get; set; }

    public int? IdSerie { get; set; }

    public int? IdUnidade { get; set; }

    public int? IdServico { get; set; }

    public virtual Serie? IdSerieNavigation { get; set; }

    public virtual Servico? IdServicoNavigation { get; set; }

    public virtual TipoProcedimento? IdTipoProcedimentoNavigation { get; set; }

    public virtual Unidade? IdUnidadeNavigation { get; set; }
}
