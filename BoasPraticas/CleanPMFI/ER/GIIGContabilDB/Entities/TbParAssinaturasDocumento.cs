using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbParAssinaturasDocumento
{
    public short IdAssinaturaDocto { get; set; }

    public short? IdEmpresa { get; set; }

    public string? DsDocumento { get; set; }

    public short? NrSequencia { get; set; }

    public int? IdServidor { get; set; }

    public string? DsCargo { get; set; }

    public byte[]? ImAssinatura { get; set; }

    public DateTime? DtInicioVigencia { get; set; }

    public DateTime? DtFimVigencia { get; set; }

    public string? DsListaOrgaosAssinaturas { get; set; }

    public virtual TbGerServidore? IdServidorNavigation { get; set; }
}
