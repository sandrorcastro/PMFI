using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Documento
{
    public int DocId { get; set; }

    public string? DocNome { get; set; }

    public string? DocOriginal { get; set; }

    /// <summary>
    /// Observações gerais sobre o documento tal como se é recomendado se a cópia deve ser autenticada ou não.
    /// </summary>
    public string? DocObservacao { get; set; }

    public virtual ICollection<AlmEntrada> AlmEntrada { get; set; } = new List<AlmEntrada>();

    public virtual ICollection<FissAtividadesDocto> FissAtividadesDoctos { get; set; } = new List<FissAtividadesDocto>();

    public virtual ICollection<FissDoctosAnexosEmpresa> FissDoctosAnexosEmpresas { get; set; } = new List<FissDoctosAnexosEmpresa>();

    public virtual ICollection<TipoProcesso> DocProTipos { get; set; } = new List<TipoProcesso>();
}
