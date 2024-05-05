using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class VwAnalisesPendentesDocumento
{
    public string? NrLocalizadorAlvara { get; set; }

    public string? DsTipoSolicitacao { get; set; }

    public long IdSolicitacaoInscricao { get; set; }

    public long? EmprCmc { get; set; }

    public string? DsRazaoSocial { get; set; }

    public string? NrCnpjCpf { get; set; }

    public string? Dsnomedocumento { get; set; }

    public byte[]? ObjConteudo { get; set; }
}
