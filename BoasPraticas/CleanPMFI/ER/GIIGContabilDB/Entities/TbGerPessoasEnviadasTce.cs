using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerPessoasEnviadasTce
{
    public int IdEnvio { get; set; }

    public short IdEmpresa { get; set; }

    public int IdPessoa { get; set; }

    public DateTime DtEnvio { get; set; }
}
