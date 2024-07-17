using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Almoxarifado
{
    public long AlmoxId { get; set; }

    public string? EmprCnpj { get; set; }

    public string? AlmoxNome { get; set; }

    public long? LocalFisicoId { get; set; }

    public string? AlmoxFone { get; set; }

    public string? AlmoxNmResp { get; set; }

    public string? AlmoxCargoResp { get; set; }

    public virtual ICollection<AlmEntrada> AlmEntradaAlmoxes { get; set; } = new List<AlmEntrada>();

    public virtual ICollection<AlmEntrada> AlmEntradaEntrAlmoxOrigems { get; set; } = new List<AlmEntrada>();

    public virtual ICollection<AlmRequisicoesIten> AlmRequisicoesItens { get; set; } = new List<AlmRequisicoesIten>();

    public virtual ICollection<AlmRequisico> AlmRequisicos { get; set; } = new List<AlmRequisico>();

    public virtual ICollection<AlmoxarifIten> AlmoxarifItens { get; set; } = new List<AlmoxarifIten>();

    public virtual ICollection<AlmoxarifLote> AlmoxarifLotes { get; set; } = new List<AlmoxarifLote>();

    public virtual ICollection<AlmoxarifadosUsuario> AlmoxarifadosUsuarios { get; set; } = new List<AlmoxarifadosUsuario>();

    public virtual LocalFisico? LocalFisico { get; set; }

    public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; } = new List<SaudeAlmoxSaldoInicial>();

    public virtual ICollection<Usuario> Usus { get; set; } = new List<Usuario>();
}
