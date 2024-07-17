using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class MoveisIten
    {
        public MoveisIten()
        {
            AcessoriosMoveisEquipamentos = new HashSet<AcessoriosMoveisEquipamento>();
        }

        public long ItemId { get; set; }
        public int ItemEspecieId { get; set; }
        public int ItemMarcaId { get; set; }
        public int ItemModeloId { get; set; }
        public int ItemUnMedId { get; set; }
        public string ItemNome { get; set; } = null!;
        public string? ItemCodBarra { get; set; }
        public decimal ItemVlrUnitario { get; set; }
        public byte[]? ItemImagem { get; set; }

        public virtual Especie ItemEspecie { get; set; } = null!;
        public virtual Marca ItemMarca { get; set; } = null!;
        public virtual Modelo ItemModelo { get; set; } = null!;
        public virtual AlmUnMed ItemUnMed { get; set; } = null!;
        public virtual ICollection<AcessoriosMoveisEquipamento> AcessoriosMoveisEquipamentos { get; set; }
    }
}
