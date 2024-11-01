﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeMedicamentoXxxxxx
{
    public int IdMedicamento { get; set; }

    public string? DsMedicamento { get; set; }

    public int? Qtde { get; set; }

    public string? IdSus { get; set; }

    public decimal? Custo { get; set; }

    public string? Posologia { get; set; }

    public int? IdTipoMedicamento { get; set; }

    public int? IdApresentacao { get; set; }

    public int? IdUnidadeMedida { get; set; }

    public string? Tipo { get; set; }

    public string? QtdePrincipioAtivo { get; set; }

    public int? IdLista { get; set; }

    public string? UniversalPrincipioAtivo { get; set; }

    public string? Codigodcb { get; set; }

    public virtual SaudeApresentacao? IdApresentacaoNavigation { get; set; }

    public virtual SaudeListaSubstancia? IdListaNavigation { get; set; }

    public virtual SaudeTipoMedicamento? IdTipoMedicamentoNavigation { get; set; }

    public virtual SaudeUnidadeMedidum? IdUnidadeMedidaNavigation { get; set; }

    public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; } = new List<SaudeAlmoxSaldoInicial>();

    public virtual ICollection<SaudeFarmaSaidaIten> SaudeFarmaSaidaItens { get; set; } = new List<SaudeFarmaSaidaIten>();

    public virtual ICollection<SaudeFarmaSaidaItensExtorno> SaudeFarmaSaidaItensExtornos { get; set; } = new List<SaudeFarmaSaidaItensExtorno>();

    public virtual ICollection<SaudeReceitaItem> SaudeReceitaItems { get; set; } = new List<SaudeReceitaItem>();

    public virtual ICollection<SaudeProgramaSaude> Idprogramas { get; set; } = new List<SaudeProgramaSaude>();
}
