using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class AtoBaixa
{
    public int AtoId { get; set; }

    public string? AtoNumero { get; set; }

    public int? AtoAno { get; set; }

    public string? AtoTipo { get; set; }

    public DateTime? AtoData { get; set; }

    public int? AtoTipoBaixaId { get; set; }

    public virtual TipoBaixa? AtoTipoBaixa { get; set; }

    public virtual ICollection<BaixaImoveisImoben> BaixaImoveisImobens { get; set; } = new List<BaixaImoveisImoben>();

    public virtual ICollection<BaixaMoveisEquipamento> BaixaMoveisEquipamentos { get; set; } = new List<BaixaMoveisEquipamento>();

    public virtual ICollection<VeiculosBaixado> VeiculosBaixados { get; set; } = new List<VeiculosBaixado>();
}
