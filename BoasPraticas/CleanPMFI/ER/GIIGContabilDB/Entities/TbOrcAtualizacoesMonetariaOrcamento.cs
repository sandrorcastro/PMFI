﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcAtualizacoesMonetariaOrcamento
{
    public int IdAtualizacao { get; set; }

    public short? IdEmpresa { get; set; }

    public int? NrDecreto { get; set; }

    public short? NrAnoDecreto { get; set; }

    public DateTime? DtDecreto { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public decimal? VlPercentualCorr { get; set; }

    public decimal? VlAtualizadoReceitas { get; set; }

    public decimal? VlAtualizadoDespesas { get; set; }

    public int? IdLeiAto { get; set; }

    public short? IdTipoAtualizacaoOrcamentariaReceita { get; set; }

    public short? IdTipoAtualizacaoOrcamentariaDespesa { get; set; }

    public virtual TbGerEmpresasGoverno? IdEmpresaNavigation { get; set; }

    public virtual TbOrcTipoAtualizacaoOrcamentarium? IdTipoAtualizacaoOrcamentariaReceitaNavigation { get; set; }

    public virtual ICollection<TbOrcAtualizacoesMonetOrcamentoDotaco> TbOrcAtualizacoesMonetOrcamentoDotacos { get; set; } = new List<TbOrcAtualizacoesMonetOrcamentoDotaco>();

    public virtual ICollection<TbOrcAtualizacoesMonetOrcamentoReceita> TbOrcAtualizacoesMonetOrcamentoReceita { get; set; } = new List<TbOrcAtualizacoesMonetOrcamentoReceita>();
}
