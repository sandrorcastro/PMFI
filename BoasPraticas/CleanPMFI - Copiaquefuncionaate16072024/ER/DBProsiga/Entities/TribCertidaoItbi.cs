using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCertidaoItbi
{
    public int CertItbiid { get; set; }

    public int? CertItbiano { get; set; }

    public int? CertItbinumero { get; set; }

    public long? CertItbichave { get; set; }

    public byte[]? CertItbiobjeto { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }
}
