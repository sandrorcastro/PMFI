using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ProdRurPropriedadesRurProdutor
{
    public int IdpropProdutor { get; set; }

    public int Idprodutor { get; set; }

    public int Idpropriedade { get; set; }

    public DateTime? ProPoDataInicio { get; set; }

    public DateTime? ProPoDataFim { get; set; }

    public string? ProPoProprietario { get; set; }

    public string? ProPoArrendatario { get; set; }

    public string? ProPoParceiro { get; set; }

    public string? ProPoObservacao { get; set; }

    public string? ProPoNumCtrArrend { get; set; }

    public DateTime? ProPoVencCtrArrend { get; set; }

    public virtual ProdRurProdutor IdprodutorNavigation { get; set; } = null!;

    public virtual ProdRurPropriedade IdpropriedadeNavigation { get; set; } = null!;

    public virtual ICollection<ProdRurNotaFiscal> ProdRurNotaFiscals { get; set; } = new List<ProdRurNotaFiscal>();

    public virtual ICollection<ProdRurProducao> ProdRurProducaos { get; set; } = new List<ProdRurProducao>();
}
