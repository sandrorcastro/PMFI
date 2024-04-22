using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VeiculosIten
    {
        public VeiculosIten()
        {
            Veiculos = new HashSet<Veiculo>();
        }

        public long VeicItemId { get; set; }
        public int? VeicItemEspecieId { get; set; }
        public int? VeicItemMarcaId { get; set; }
        public int? VeicItemModeloId { get; set; }
        public int? VeicItemUnMedId { get; set; }
        public string? VeicItemNome { get; set; }
        public string? VeicItemCodBarra { get; set; }
        public decimal? VeicItemVlrUnitario { get; set; }
        public byte[]? VeicItemImagem { get; set; }

        public virtual Especie? VeicItemEspecie { get; set; }
        public virtual Marca? VeicItemMarca { get; set; }
        public virtual Modelo? VeicItemModelo { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
