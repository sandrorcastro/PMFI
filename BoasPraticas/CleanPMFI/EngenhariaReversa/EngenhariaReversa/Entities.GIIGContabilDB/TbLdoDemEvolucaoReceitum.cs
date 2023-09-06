using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLdoDemEvolucaoReceitum
    {
        public int IdDemEvoReceita { get; set; }
        public int? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrAnoLdo { get; set; }
        public int? IdReceita { get; set; }
        public decimal? VlRealizAno3 { get; set; }
        public decimal? VlRealizAno2 { get; set; }
        public decimal? VlEstimAno1 { get; set; }
        public decimal? VlProjAnoRef { get; set; }
        public decimal? VlProjAno1 { get; set; }
        public decimal? VlProjAno2 { get; set; }
        public string? DsMetodCalculo { get; set; }
    }
}
