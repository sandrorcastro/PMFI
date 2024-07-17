using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Almoxarifado
    {
        public Almoxarifado()
        {
            AlmEntradaAlmoxes = new HashSet<AlmEntrada>();
            AlmEntradaEntrAlmoxOrigems = new HashSet<AlmEntrada>();
            AlmRequisicoesItens = new HashSet<AlmRequisicoesIten>();
            AlmRequisicos = new HashSet<AlmRequisico>();
            AlmoxarifItens = new HashSet<AlmoxarifIten>();
            AlmoxarifLotes = new HashSet<AlmoxarifLote>();
            AlmoxarifadosUsuarios = new HashSet<AlmoxarifadosUsuario>();
            SaudeAlmoxSaldoInicials = new HashSet<SaudeAlmoxSaldoInicial>();
            Usus = new HashSet<Usuario>();
        }

        public long AlmoxId { get; set; }
        public string? EmprCnpj { get; set; }
        public string? AlmoxNome { get; set; }
        public long? LocalFisicoId { get; set; }
        public string? AlmoxFone { get; set; }
        public string? AlmoxNmResp { get; set; }
        public string? AlmoxCargoResp { get; set; }

        public virtual LocalFisico? LocalFisico { get; set; }
        public virtual ICollection<AlmEntrada> AlmEntradaAlmoxes { get; set; }
        public virtual ICollection<AlmEntrada> AlmEntradaEntrAlmoxOrigems { get; set; }
        public virtual ICollection<AlmRequisicoesIten> AlmRequisicoesItens { get; set; }
        public virtual ICollection<AlmRequisico> AlmRequisicos { get; set; }
        public virtual ICollection<AlmoxarifIten> AlmoxarifItens { get; set; }
        public virtual ICollection<AlmoxarifLote> AlmoxarifLotes { get; set; }
        public virtual ICollection<AlmoxarifadosUsuario> AlmoxarifadosUsuarios { get; set; }
        public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; }

        public virtual ICollection<Usuario> Usus { get; set; }
    }
}
