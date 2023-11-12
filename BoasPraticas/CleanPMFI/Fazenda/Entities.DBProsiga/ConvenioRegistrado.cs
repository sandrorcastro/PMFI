using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ConvenioRegistrado
{
    public int ConvRegId { get; set; }

    public int? ConvenioId { get; set; }

    public string? BancoId { get; set; }

    public string? ConvRegIdentificacao { get; set; }

    public DateTime? ConvRegDataInicial { get; set; }

    public DateTime? ConvRegDataFinal { get; set; }

    public string? ConvContaContabil { get; set; }

    public string? ConvAgenciaId { get; set; }

    public string? ConvContaCorId { get; set; }

    public bool? ConvflAtivo { get; set; }

    public virtual Banco? Banco { get; set; }

    public virtual ConvenioBanco? Convenio { get; set; }
}
