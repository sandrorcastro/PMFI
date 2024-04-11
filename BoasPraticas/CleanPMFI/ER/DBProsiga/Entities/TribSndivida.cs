using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSndivida
{
    /// <summary>
    /// Código de identificacao das dividas geradas conforme arquivo importado.
    /// </summary>
    public int SndivId { get; set; }

    /// <summary>
    /// Código de identificação de cada linha de divida contida no arquivo.
    /// </summary>
    public int? SnarqDetId { get; set; }

    /// <summary>
    /// Código de identificação das dividas de empresas.
    /// </summary>
    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribSnarquivoDetalhe? SnarqDet { get; set; }
}
