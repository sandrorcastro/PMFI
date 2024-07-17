using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ProdRurProdutor
{
    public int Idprodutor { get; set; }

    public long ConId { get; set; }

    public string? ProdCodAnterior { get; set; }

    public string? ProdInscCadIcms { get; set; }

    public string? ProdInscCadInss { get; set; }

    public string? ProdInscrRecFederal { get; set; }

    public DateTime? ProdDataCadastro { get; set; }

    public string? ProdUsuCad { get; set; }

    public string? ProdUsuUltAlt { get; set; }

    public DateTime? ProdDataUltAlt { get; set; }

    public virtual Contribuinte Con { get; set; } = null!;

    public virtual ICollection<ProdRurProdutorFamilium> ProdRurProdutorFamilia { get; set; } = new List<ProdRurProdutorFamilium>();

    public virtual ICollection<ProdRurPropriedadesRurProdutor> ProdRurPropriedadesRurProdutors { get; set; } = new List<ProdRurPropriedadesRurProdutor>();
}
