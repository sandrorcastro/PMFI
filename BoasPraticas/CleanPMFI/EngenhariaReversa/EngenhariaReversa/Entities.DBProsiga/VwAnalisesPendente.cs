using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VwAnalisesPendente
    {
        public string? NrLocalizadorAlvara { get; set; }
        public string? DsTipoSolicitacao { get; set; }
        public long IdSolicitacaoInscricao { get; set; }
        public long? EmprCmc { get; set; }
        public string? DsRazaoSocial { get; set; }
        public string? NrCnpjCpf { get; set; }
        public string FlStatus { get; set; } = null!;
        public string? Dsnomedocumento { get; set; }
        public long IdSolicitacaoInscricaoDocumento { get; set; }
        public int? ObjetoId { get; set; }
    }
}
