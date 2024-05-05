using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAinfarquivoDividasLancada
{
    public int IdAinfarquivoDividas { get; set; }

    public int IdAinfarquivo { get; set; }

    public int IdainfarquivoDetalhes { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribAinfarquivo IdAinfarquivoNavigation { get; set; } = null!;

    public virtual TribAinfarquivoDetalhe IdainfarquivoDetalhesNavigation { get; set; } = null!;
}
