using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class PubDocumento
{
    public int PubDocumentoId { get; set; }

    public string? PubNomeDocumento { get; set; }

    public int? DivId { get; set; }

    public int? TipoId { get; set; }

    public string? PubObjeto { get; set; }

    public string? PubUsuarioInclusao { get; set; }

    public DateTime? PubDataInclusao { get; set; }

    public string? PubPublicaInternet { get; set; }

    public DateTime? PubData { get; set; }

    public DateTime? PubDataPublicacao { get; set; }

    public byte[]? PubImagem { get; set; }

    public string? PubTamanho { get; set; }

    public string? PubCaminho { get; set; }

    public string? PubOrgaoNumero { get; set; }

    public virtual Diviso? Div { get; set; }

    public virtual PubTipoDocumento? Tipo { get; set; }
}
