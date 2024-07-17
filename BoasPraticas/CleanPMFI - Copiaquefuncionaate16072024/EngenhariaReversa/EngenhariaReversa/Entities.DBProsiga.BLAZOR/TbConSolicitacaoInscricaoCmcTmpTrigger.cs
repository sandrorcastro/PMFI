using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoCmcTmpTrigger
    {
        public DateTime? DataInclusao { get; set; }
        public long? IdsolicitacaoInscricao { get; set; }
        public string? NrLocalizadorAlvara { get; set; }
        public string? NrCnpjCpf { get; set; }
        public string? DsRazaoSocial { get; set; }
        public long? EmprCmc { get; set; }
        public string? Usuario { get; set; }
    }
}
