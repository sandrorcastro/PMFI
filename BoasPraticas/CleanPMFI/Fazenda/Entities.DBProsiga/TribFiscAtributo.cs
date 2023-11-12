﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscAtributo
{
    /// <summary>
    /// Código de identificação dos atributos.
    /// </summary>
    public int IdAtributo { get; set; }

    /// <summary>
    /// Nome do atributo.
    /// </summary>
    public string? NmAtributo { get; set; }

    public virtual ICollection<TribFiscVistoriasAtributo> TribFiscVistoriasAtributos { get; set; } = new List<TribFiscVistoriasAtributo>();

    public virtual ICollection<TribFiscTiposVistorium> TipoVists { get; set; } = new List<TribFiscTiposVistorium>();
}
