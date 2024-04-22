using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeMedicamentoXxxxxx
    {
        public SaudeMedicamentoXxxxxx()
        {
            SaudeAlmoxSaldoInicials = new HashSet<SaudeAlmoxSaldoInicial>();
            SaudeFarmaSaidaItens = new HashSet<SaudeFarmaSaidaIten>();
            SaudeFarmaSaidaItensExtornos = new HashSet<SaudeFarmaSaidaItensExtorno>();
            SaudeReceitaItems = new HashSet<SaudeReceitaItem>();
            Idprogramas = new HashSet<SaudeProgramaSaude>();
        }

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
        public virtual ICollection<SaudeAlmoxSaldoInicial> SaudeAlmoxSaldoInicials { get; set; }
        public virtual ICollection<SaudeFarmaSaidaIten> SaudeFarmaSaidaItens { get; set; }
        public virtual ICollection<SaudeFarmaSaidaItensExtorno> SaudeFarmaSaidaItensExtornos { get; set; }
        public virtual ICollection<SaudeReceitaItem> SaudeReceitaItems { get; set; }

        public virtual ICollection<SaudeProgramaSaude> Idprogramas { get; set; }
    }
}
