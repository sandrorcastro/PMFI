using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AguaDividasServAgua
{
    public long DividasServAguaId { get; set; }

    public long? SolicServParcId { get; set; }

    public long LeituraId { get; set; }

    public virtual AguaLeituraHidrometro Leitura { get; set; } = null!;

    public virtual AguaReqSolicServParc? SolicServParc { get; set; }
}
