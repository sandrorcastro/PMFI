using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSimuladosIptu
    {
        public TribSimuladosIptu()
        {
            TribSimuladoIptuoperacos = new HashSet<TribSimuladoIptuoperaco>();
            TribSimuladosIptuimoveis = new HashSet<TribSimuladosIptuimovei>();
        }

        public int SimuId { get; set; }
        public string? SimuNome { get; set; }
        public DateTime? SimuData { get; set; }
        public short? SimuAno { get; set; }
        public decimal? SimuVlrUf { get; set; }
        public string? SimuImportado { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? SimuVencUnica1 { get; set; }
        public decimal? SimuDescUnica1 { get; set; }
        public DateTime? SimuVencUnica2 { get; set; }
        public decimal? SimuDescUnica2 { get; set; }
        public DateTime? SimuDataParc1 { get; set; }
        public string? SimuCalculado { get; set; }
        public short? SimuParcelas { get; set; }

        public virtual ICollection<TribSimuladoIptuoperaco> TribSimuladoIptuoperacos { get; set; }
        public virtual ICollection<TribSimuladosIptuimovei> TribSimuladosIptuimoveis { get; set; }
    }
}
