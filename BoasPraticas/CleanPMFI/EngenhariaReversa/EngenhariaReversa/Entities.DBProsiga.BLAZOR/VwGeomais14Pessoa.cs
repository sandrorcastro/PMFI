using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VwGeomais14Pessoa
    {
        public long CdPessoa { get; set; }
        public string? CdCpfCnpj { get; set; }
        public string? NmPessoaRazaoSocial { get; set; }
        public string TipoPessoa { get; set; } = null!;
    }
}
