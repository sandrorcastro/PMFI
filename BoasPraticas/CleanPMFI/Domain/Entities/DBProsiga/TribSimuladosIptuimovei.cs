using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSimuladosIptuimovei
    {
        public TribSimuladosIptuimovei()
        {
            TribSimuladosIptuedifCaracs = new HashSet<TribSimuladosIptuedifCarac>();
            TribSimuladosIptutestada = new HashSet<TribSimuladosIptutestada>();
        }

        public int SimuId { get; set; }
        public long EdificacaoId { get; set; }
        public long? TerrenoId { get; set; }
        public long? EdifEdificacaoEnglobamento { get; set; }
        public string? EdifContinuacaoTerreno { get; set; }
        public string? EdifCaracteristica { get; set; }
        public int? CategId { get; set; }
        public int? Idplanta { get; set; }
        public decimal? ValorVenalCalculo { get; set; }
        public decimal? ValorVenalEdificacao { get; set; }
        public decimal? ValorVenalTerrenoParaEdificacao { get; set; }
        public int? LogradId { get; set; }
        public int? Idloteamento { get; set; }
        public short? EdifPontosEdificacao { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
        public virtual TribSimuladosIptu Simu { get; set; } = null!;
        public virtual ICollection<TribSimuladosIptuedifCarac> TribSimuladosIptuedifCaracs { get; set; }
        public virtual ICollection<TribSimuladosIptutestada> TribSimuladosIptutestada { get; set; }
    }
}
