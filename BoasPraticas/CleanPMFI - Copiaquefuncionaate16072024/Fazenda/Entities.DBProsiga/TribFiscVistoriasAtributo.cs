using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscVistoriasAtributo
{
    /// <summary>
    /// Código de identificação da vistoria.
    /// </summary>
    public int VistId { get; set; }

    /// <summary>
    /// Código de identificação do atributo.
    /// </summary>
    public int IdAtributo { get; set; }

    /// <summary>
    /// Valor do atributo para a vistoria.
    /// </summary>
    public string? VlAtributo { get; set; }

    public virtual TribFiscAtributo IdAtributoNavigation { get; set; } = null!;

    public virtual TribFiscVistoria Vist { get; set; } = null!;
}
