﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbImoObra
{
    public int Idobra { get; set; }

    public string ImoImoveisInscricao { get; set; } = null!;

    public string ImoImoveisCnpjfilial { get; set; } = null!;

    public string? NmObra { get; set; }

    public string? DsObjetoObra { get; set; }

    public DateTime DtInicio { get; set; }

    public DateTime? DtEstimadaFim { get; set; }

    public DateTime? DtFim { get; set; }

    public decimal? VlEstimado { get; set; }

    public decimal? VlGasto { get; set; }

    public short? CdProprio { get; set; }

    public virtual ImobensImovei ImoImoveis { get; set; } = null!;

    public virtual ICollection<TbImoMovimentoObra> TbImoMovimentoObras { get; set; } = new List<TbImoMovimentoObra>();

    public virtual ICollection<TbImoObrasDepuDesp> TbImoObrasDepuDesps { get; set; } = new List<TbImoObrasDepuDesp>();
}
