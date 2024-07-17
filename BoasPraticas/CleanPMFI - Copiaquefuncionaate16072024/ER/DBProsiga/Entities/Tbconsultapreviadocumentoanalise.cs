using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tbconsultapreviadocumentoanalise
{
    public int Idanalisedocumento { get; set; }

    public int Idconsulta { get; set; }

    public short Iddocumento { get; set; }

    public byte[] Byanexo { get; set; } = null!;

    public string Flparecer { get; set; } = null!;

    public DateTime? Dtparecer { get; set; }

    public string? Dsparecer { get; set; }

    public int? Idusuarioparecer { get; set; }

    public string? Contenttype { get; set; }

    public string? Data { get; set; }
}
