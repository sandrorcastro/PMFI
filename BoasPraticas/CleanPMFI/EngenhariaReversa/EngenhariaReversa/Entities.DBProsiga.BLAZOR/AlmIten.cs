using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AlmIten
    {
        public AlmIten()
        {
            AlmEntradaItens = new HashSet<AlmEntradaIten>();
            AlmRequisicoesItens = new HashSet<AlmRequisicoesIten>();
            AlmoxarifItens = new HashSet<AlmoxarifIten>();
            AlmoxarifLotes = new HashSet<AlmoxarifLote>();
        }

        public long ItemId { get; set; }
        public int? ItemEspecieId { get; set; }
        public int? ItemMarcaId { get; set; }
        public int? ItemModeloId { get; set; }
        public int? ItemUnMedId { get; set; }
        public string? ItemNome { get; set; }
        public string? ItemObserv { get; set; }
        public string? ItemCodBarra { get; set; }
        public decimal? ItemVlrUnitario { get; set; }

        public virtual Especie? ItemEspecie { get; set; }
        public virtual Marca? ItemMarca { get; set; }
        public virtual Modelo? ItemModelo { get; set; }
        public virtual AlmUnMed? ItemUnMed { get; set; }
        public virtual ICollection<AlmEntradaIten> AlmEntradaItens { get; set; }
        public virtual ICollection<AlmRequisicoesIten> AlmRequisicoesItens { get; set; }
        public virtual ICollection<AlmoxarifIten> AlmoxarifItens { get; set; }
        public virtual ICollection<AlmoxarifLote> AlmoxarifLotes { get; set; }
    }
}
